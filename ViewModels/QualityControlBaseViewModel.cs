using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Enums;
using FloorDigitalization.Helpers;
using FloorDigitalization.Models;
using Serilog;

namespace FloorDigitalization.ViewModels;

public partial class QualityControlBaseViewModel<T1> : ViewModelBase
{
    private OperationNames _operationName;
    private ScreenNames _firstScreenName;
    [ObservableProperty]
    private T1 _firstRecord;
    [ObservableProperty]
    private User _firstUser;
    [ObservableProperty]
    private bool _firstSaveIsEnabled = false;
    [ObservableProperty]
    private bool _firstStartPhase = true;
    [ObservableProperty]
    private bool _firstMidPhase = false;
    [ObservableProperty]
    private bool _firstEndPhase = false;
    [ObservableProperty]
    private bool _firstNtOffStart = true;
    [ObservableProperty]
    private bool _firstNtOffMid = true;
    [ObservableProperty]
    private bool _firstNtOffEnd = true;

    public QualityControlBaseViewModel(T1 first, User firstUser, OperationNames operationName, ScreenNames screenName)
    {
        FirstRecord = first;
        FirstUser = firstUser;
        _operationName = operationName;
        _firstScreenName = screenName;

        FirstUser.Shift = Shift.GetCurrentShift();
    }
    public QualityControlBaseViewModel(OperationNames operationName, ScreenNames screenName)
    {
        FirstRecord = Activator.CreateInstance<T1>();
        FirstUser = new User();
        _operationName = operationName;
        _firstScreenName = screenName;

        FirstUser.Shift = Shift.GetCurrentShift();
    }

    [RelayCommand(CanExecute = nameof(CanSaveFirst))]
    private void SaveFirst()
    {
        if(FirstRecord != null)
        {
            ShiftPhase currentPhase = GetCurrentShiftPhase(FirstStartPhase, FirstMidPhase, FirstEndPhase);
            SaveRecord(_firstScreenName.ToString(), FirstUser, FirstRecord, currentPhase, NoWorkActivatedForCurrentPhase(currentPhase, FirstNtOffStart, FirstNtOffMid, FirstNtOffEnd));
        }
        else
        {
            throw new NullReferenceException($"object {nameof(FirstRecord)} is null on method SaveFirst");
        }

        MovePhaseForward(RecordNumber.First);

        SaveFirstCommand.NotifyCanExecuteChanged(); // disables the button after executing
    }

    /// <summary>
    /// Sets the disable property of the button validating the user input, with the current phase
    /// </summary>
    /// <returns>bool</returns>
    private bool CanSaveFirst() => CanSave(
        FirstUser, 
        FirstRecord!, 
        GetCurrentShiftPhase(FirstStartPhase, FirstMidPhase, FirstEndPhase),
        NoWorkActivatedForCurrentPhase(
            GetCurrentShiftPhase(FirstStartPhase, FirstMidPhase, FirstEndPhase),
            FirstNtOffStart,
            FirstNtOffMid,
            FirstNtOffEnd
        ));

    /// <summary>
    /// Gets if the current phase has the NT enabled
    /// </summary>
    /// <returns>bool</returns>
    internal bool NoWorkActivatedForCurrentPhase(ShiftPhase phase, bool ntOffStart, bool ntOffMid, bool ntOffEnd)
    {
        switch (phase)
        {
            case ShiftPhase.Start:
                return !ntOffStart;
            case ShiftPhase.Mid:
                return !ntOffMid;
            case ShiftPhase.End:
                return !ntOffEnd;
            default:
                return false;
        }
    } 

    /// <summary>
    /// Gets the current phase using the shift enum
    /// </summary>
    /// <param name="startPhase">Current Dcp list start parameter</param>
    /// <param name="midPhase">Current Dcp list Mid parameter</param>
    /// <param name="endPhase">Current Dcp list End parameter</param>
    /// <returns>ShiftPhase enum</returns>
    /// <exception cref="InvalidOperationException"></exception>
    internal ShiftPhase GetCurrentShiftPhase(bool startPhase, bool midPhase, bool endPhase)
    {
        if (startPhase)
            return ShiftPhase.Start;
        else if (midPhase)
            return ShiftPhase.Mid;
        else if (endPhase)
            return ShiftPhase.End;
        else
            return ShiftPhase.None;
    }


    internal void SaveRecord(string _fileName, User _user, object _equipment, ShiftPhase _shiftPhase, bool _noWork)
    {
        MyCsvHelper.SaveRecord(OperationNames.RouteLocal,
            _fileName,
            _user, 
            _equipment, 
            _shiftPhase,
            _noWork);
        // OneDrive
        try
        {
            OperationNames opName = _operationName;
            #if DEBUG
                opName = OperationNames.DebugPc;  
            #endif
            MyCsvHelper.SaveRecord(opName,
                _fileName,
                _user, 
                _equipment, 
                _shiftPhase,
                _noWork);
        }
        catch (Exception)
        {
            string shiftPhase = _shiftPhase == ShiftPhase.Start ? "Start" : _shiftPhase == ShiftPhase.Mid ? "Mid" : "End";
            Log.Error("Unable to save Inspeccion to OneDrive at Date: {Date}, Shift:{Shift}, Phase: {Phase}", _user.Date, _user.Shift, shiftPhase);
            throw;
        }
        
    }

    internal bool CanSave(User _user, object _record, ShiftPhase _phase, bool noWorkActivated)
    {
        // Vaidate if this is the logic we need
        if(_record == null)
        {
            throw new NullReferenceException($"object {nameof(_record)} is null on method CanSave");
        }
        
        if (_user.Nomina == 0 || _user.Nomina == null)
            return false; 

        if(_phase == ShiftPhase.None)
            return false;
        
        if (noWorkActivated)
            return true;

        var validator = _record as ObservableValidator;
        
        if (validator!.HasErrors)
            return false;

        return DataValidation.Validate(_record, _phase);
    }

    [RelayCommand]
    private void GetOperator(User user)
    {
        int code;
        if (user.Nomina is null)
            return;
        else
            code = (int)user.Nomina;

        user.Name = CsvOperatorReader.GetOperator(code);
    }

    [RelayCommand]
    private void ToggleNoTrabajoFirst()
    {
        SetNoTrabajo(RecordNumber.First);
    }

    internal void SetNoTrabajo(RecordNumber r)
    {
        if(r == RecordNumber.First)
        {
            if (FirstStartPhase)
            {
                FirstNtOffStart = !FirstNtOffStart;
            }
            else if (FirstMidPhase)
            {
                FirstNtOffMid = !FirstNtOffMid;
            }
            else if (FirstEndPhase)
            {
                FirstNtOffEnd = !FirstNtOffEnd;
            }
            SaveFirstCommand.NotifyCanExecuteChanged();
        }
    }

    internal void MovePhaseForward(RecordNumber recordNumber)
    {
        if(recordNumber == RecordNumber.First)
        {
            FirstEndPhase = FirstMidPhase;
            FirstMidPhase = FirstStartPhase;
            FirstStartPhase = false;
        }
    }

}

public partial class QualityControlBaseViewModel<T1, T2> : QualityControlBaseViewModel<T1>
{
    [ObservableProperty]
    private T2 _secondRecord;
    [ObservableProperty]
    private User _secondUser;
    private ScreenNames _secondScreenName;
    [ObservableProperty]
    private bool _secondSaveIsEnabled = false;
    [ObservableProperty]
    private bool _secondStartPhase = true;
    [ObservableProperty]
    private bool _secondMidPhase = false;
    [ObservableProperty]
    private bool _secondEndPhase = false;
    [ObservableProperty]
    private bool _secondNtOffStart = true;
    [ObservableProperty]
    private bool _secondNtOffMid = true;
    [ObservableProperty]
    private bool _secondNtOffEnd = true;

    public QualityControlBaseViewModel(T1 first, User firstUser, T2 second, User secondUser, OperationNames operationName, ScreenNames firstScreenName, ScreenNames secondScreenName) : base(first, firstUser, operationName, firstScreenName)
    {
        SecondRecord = second;
        SecondUser = secondUser;
        _secondScreenName = secondScreenName;

        SecondUser.Shift = Shift.GetCurrentShift();
    }

    public QualityControlBaseViewModel(OperationNames operationName, ScreenNames firstScreenName, ScreenNames secondScreenName) : base(operationName, firstScreenName)
    {
        SecondRecord = Activator.CreateInstance<T2>();
        SecondUser = new User();
        _secondScreenName = secondScreenName;

        SecondUser.Shift = Shift.GetCurrentShift();
    }

    [RelayCommand(CanExecute = nameof(CanSaveSecond))]
    private void SaveSecond()
    {
        if(SecondRecord != null)
        {
            ShiftPhase currentPhase = GetCurrentShiftPhase(SecondStartPhase, SecondMidPhase, SecondEndPhase);
            SaveRecord(_secondScreenName.ToString(), SecondUser, SecondRecord, currentPhase, NoWorkActivatedForCurrentPhase(currentPhase, SecondNtOffStart, SecondNtOffMid, SecondNtOffEnd));
        }
        else
        {
            throw new NullReferenceException($"object {nameof(SecondRecord)} is null on method SaveFirst");
        }

        MovePhaseForward(RecordNumber.Second);

        SaveSecondCommand.NotifyCanExecuteChanged(); // disables the button after executing
    }

    /// <summary>
    /// Sets the disable property of the button validating the user input, with the current phase
    /// </summary>
    /// <returns>bool</returns>
    private bool CanSaveSecond() => CanSave(
        SecondUser, 
        SecondRecord!, 
        GetCurrentShiftPhase(SecondStartPhase, SecondMidPhase, SecondEndPhase),
        NoWorkActivatedForCurrentPhase(
            GetCurrentShiftPhase(SecondStartPhase, SecondMidPhase, SecondEndPhase),
            SecondNtOffStart,
            SecondNtOffMid,
            SecondNtOffEnd
        ));

    internal new void MovePhaseForward(RecordNumber recordNumber)
    {
        if(recordNumber == RecordNumber.Second)
        {
            SecondEndPhase = SecondMidPhase;
            SecondMidPhase = SecondStartPhase;
            SecondStartPhase = false;
        }
        else
            base.MovePhaseForward(recordNumber); // runs the base class method
        
    }

    internal new void SetNoTrabajo(RecordNumber r)
    {
        if(r == RecordNumber.Second)
        {
            if (SecondStartPhase)
            {
                SecondNtOffStart = !SecondNtOffStart;
            }
            else if (SecondMidPhase)
            {
                SecondNtOffMid = !SecondNtOffMid;
            }
            else if (SecondEndPhase)
            {
                SecondNtOffEnd = !SecondNtOffEnd;
            }
            SaveSecondCommand.NotifyCanExecuteChanged();
        }
        else
            base.SetNoTrabajo(r);
    }

    [RelayCommand]
    private void ToggleNoTrabajoSecond()
    {
        SetNoTrabajo(RecordNumber.Second);
    }

}

public partial class QualityControlBaseViewModel<T1, T2, T3> : QualityControlBaseViewModel<T1, T2>
{
    [ObservableProperty]
    private T3 _thirdRecord;
    [ObservableProperty]
    private User _thirdUser;
    private ScreenNames _thirdScreenName;
    [ObservableProperty]
    private bool _thirdSaveIsEnabled = false;
    [ObservableProperty]
    private bool _thirdStartPhase = true;
    [ObservableProperty]
    private bool _thirdMidPhase = false;
    [ObservableProperty]
    private bool _thirdEndPhase = false;
    [ObservableProperty]
    private bool _thirdNtOffStart = true;
    [ObservableProperty]
    private bool _thirdNtOffMid = true;
    [ObservableProperty]
    private bool _thirdNtOffEnd = true;

    public QualityControlBaseViewModel(T1 first, User firstUser,
                                        T2 second, User secondUser, 
                                        T3 third, User thirdUser,
                                        OperationNames operationName,
                                        ScreenNames firstScreenName, ScreenNames secondScreenName, ScreenNames thirdScreenName) : 
                                        base(first, firstUser, second, secondUser, operationName, firstScreenName, secondScreenName)
    {
        ThirdRecord = third;
        ThirdUser = thirdUser;
        _thirdScreenName = thirdScreenName;

        ThirdUser.Shift = Shift.GetCurrentShift();
    }

    public QualityControlBaseViewModel(OperationNames operationName,
                                        ScreenNames firstScreenName, ScreenNames secondScreenName, ScreenNames thirdScreenName) : 
                                        base(operationName, firstScreenName, secondScreenName)
    {
        ThirdRecord = Activator.CreateInstance<T3>();
        ThirdUser = new User();
        _thirdScreenName = thirdScreenName;

        ThirdUser.Shift = Shift.GetCurrentShift();
    }

    [RelayCommand(CanExecute = nameof(CanSaveThird))]
    private void SaveThird()
    {
        if(ThirdRecord != null)
        {
            ShiftPhase currentPhase = GetCurrentShiftPhase(ThirdStartPhase, ThirdMidPhase, ThirdEndPhase);
            SaveRecord(_thirdScreenName.ToString(), ThirdUser, ThirdRecord, currentPhase, NoWorkActivatedForCurrentPhase(currentPhase, ThirdNtOffStart, ThirdNtOffMid, ThirdNtOffEnd));
        }
        else
        {
            throw new NullReferenceException($"object {nameof(ThirdRecord)} is null on method SaveFirst");
        }

        MovePhaseForward(RecordNumber.Third);

        SaveThirdCommand.NotifyCanExecuteChanged(); // disables the button after executing
    }

    /// <summary>
    /// Sets the disable property of the button validating the user input, with the current phase
    /// </summary>
    /// <returns>bool</returns>
    private bool CanSaveThird() => CanSave(
        ThirdUser, 
        ThirdRecord!, 
        GetCurrentShiftPhase(ThirdStartPhase, ThirdMidPhase, ThirdEndPhase),
        NoWorkActivatedForCurrentPhase(
            GetCurrentShiftPhase(ThirdStartPhase, ThirdMidPhase, ThirdEndPhase),
            ThirdNtOffStart,
            ThirdNtOffMid,
            ThirdNtOffEnd
        ));

    internal new void MovePhaseForward(RecordNumber recordNumber)
    {
        if(recordNumber == RecordNumber.Third)
        {
            ThirdEndPhase = ThirdMidPhase;
            ThirdMidPhase = ThirdStartPhase;
            ThirdStartPhase = false;
        }
        else
            base.MovePhaseForward(recordNumber); // runs the base class method
        
    }

    internal new void SetNoTrabajo(RecordNumber r)
    {
        if(r == RecordNumber.Third)
        {
            if (ThirdStartPhase)
            {
                ThirdNtOffStart = !ThirdNtOffStart;
            }
            else if (ThirdMidPhase)
            {
                ThirdNtOffMid = !ThirdNtOffMid;
            }
            else if (ThirdEndPhase)
            {
                ThirdNtOffEnd = !ThirdNtOffEnd;
            }
            SaveThirdCommand.NotifyCanExecuteChanged();
        }
        else
            base.SetNoTrabajo(r);
    }

    [RelayCommand]
    private void ToggleNoTrabajoThird()
    {
        SetNoTrabajo(RecordNumber.Third);
    }

}

public partial class QualityControlBaseViewModel<T1, T2, T3, T4> : QualityControlBaseViewModel<T1, T2, T3>
{
    [ObservableProperty]
    private T4 _forthRecord;
    [ObservableProperty]
    private User _forthUser;
    private ScreenNames _forthScreenName;
    [ObservableProperty]
    private bool _forthSaveIsEnabled = false;
    [ObservableProperty]
    private bool _forthStartPhase = true;
    [ObservableProperty]
    private bool _forthMidPhase = false;
    [ObservableProperty]
    private bool _forthEndPhase = false;
    [ObservableProperty]
    private bool _forthNtOffStart = true;
    [ObservableProperty]
    private bool _forthNtOffMid = true;
    [ObservableProperty]
    private bool _forthNtOffEnd = true;

    public QualityControlBaseViewModel(T1 first, User firstUser,
                                        T2 second, User secondUser, 
                                        T3 third, User thirdUser,
                                        T4 forth, User forthUser,
                                        OperationNames operationName,
                                        ScreenNames firstScreenName, ScreenNames secondScreenName, ScreenNames thirdScreenName, ScreenNames forthScreenName) : 
                                        base(first, firstUser, second, secondUser, third, thirdUser, operationName, firstScreenName, secondScreenName, thirdScreenName)
    {
        ForthRecord = forth;
        ForthUser = forthUser;
        _forthScreenName = forthScreenName;

        forthUser.Shift = Shift.GetCurrentShift();
    }

    public QualityControlBaseViewModel(OperationNames operationName,
                                        ScreenNames firstScreenName, ScreenNames secondScreenName, ScreenNames thirdScreenName, ScreenNames forthScreenName) : 
                                        base(operationName, firstScreenName, secondScreenName, thirdScreenName)
    {
        ForthRecord = Activator.CreateInstance<T4>();
        ForthUser = new User();
        _forthScreenName = forthScreenName;

        ForthUser.Shift = Shift.GetCurrentShift();
    }

    [RelayCommand(CanExecute = nameof(CanSaveForth))]
    private void SaveForth()
    {
        if(ForthRecord != null)
        {
            ShiftPhase currentPhase = GetCurrentShiftPhase(ForthStartPhase, ForthMidPhase, ForthEndPhase);
            SaveRecord(_forthScreenName.ToString(), ForthUser, ForthRecord, currentPhase, NoWorkActivatedForCurrentPhase(currentPhase, ForthNtOffStart, ForthNtOffMid, ForthNtOffEnd));
        }
        else
        {
            throw new NullReferenceException($"object {nameof(ForthRecord)} is null on method SaveFirst");
        }

        MovePhaseForward(RecordNumber.Forth);

        SaveForthCommand.NotifyCanExecuteChanged(); // disables the button after executing
    }

    /// <summary>
    /// Sets the disable property of the button validating the user input, with the current phase
    /// </summary>
    /// <returns>bool</returns>
    private bool CanSaveForth() => CanSave(
        ForthUser, 
        ForthRecord!, 
        GetCurrentShiftPhase(ForthStartPhase, ForthMidPhase, ForthEndPhase),
        NoWorkActivatedForCurrentPhase(
            GetCurrentShiftPhase(ForthStartPhase, ForthMidPhase, ForthEndPhase),
            ForthNtOffStart,
            ForthNtOffMid,
            ForthNtOffEnd
        ));

    internal new void MovePhaseForward(RecordNumber recordNumber)
    {
        if(recordNumber == RecordNumber.Forth)
        {
            // TODO: This logic should be on a singular place and not fixed for the record number
            // if(typeof(T4) == typeof(GenVPrincipal.Models.Pintura))
            // {
            //     ForthEndPhase = ForthStartPhase; 
            //     ForthStartPhase = false;
            //     return;
            // }
            ForthEndPhase = ForthMidPhase;
            ForthMidPhase = ForthStartPhase;
            ForthStartPhase = false;
        }
        else
            base.MovePhaseForward(recordNumber); // runs the base class method
        
    }

    internal new void SetNoTrabajo(RecordNumber r)
    {
        if(r == RecordNumber.Forth)
        {
            if (ForthStartPhase)
            {
                ThirdNtOffStart = !ForthNtOffStart;
            }
            else if (ForthMidPhase)
            {
                ForthNtOffMid = !ForthNtOffMid;
            }
            else if (ForthEndPhase)
            {
                ForthNtOffEnd = !ForthNtOffEnd;
            }
            SaveForthCommand.NotifyCanExecuteChanged();
        }
        else
            base.SetNoTrabajo(r);
    }

    [RelayCommand]
    private void ToggleNoTrabajoForth()
    {
        SetNoTrabajo(RecordNumber.Forth);
    }

}

public partial class QualityControlBaseViewModel<T1, T2, T3, T4, T5> : QualityControlBaseViewModel<T1, T2, T3, T4>
{
    [ObservableProperty]
    private T5 _fifthRecord;
    [ObservableProperty]
    private User _fifthUser;
    private ScreenNames _fifthScreenName;
    [ObservableProperty]
    private bool _fifthSaveIsEnabled = false;
    [ObservableProperty]
    private bool _fifthStartPhase = true;
    [ObservableProperty]
    private bool _fifthMidPhase = false;
    [ObservableProperty]
    private bool _fifthEndPhase = false;
    [ObservableProperty]
    private bool _fifthNtOffStart = true;
    [ObservableProperty]
    private bool _fifthNtOffMid = true;
    [ObservableProperty]
    private bool _fifthNtOffEnd = true;

    public QualityControlBaseViewModel(T1 first, User firstUser,
                                        T2 second, User secondUser, 
                                        T3 third, User thirdUser,
                                        T4 forth, User forthUser,
                                        T5 fifth, User fifthUser,
                                        OperationNames operationName,
                                        ScreenNames firstScreenName, ScreenNames secondScreenName, ScreenNames thirdScreenName, ScreenNames forthScreenName, ScreenNames fifthScreenName) : 
                                        base(first, firstUser, second, secondUser, third, thirdUser, forth, forthUser, operationName, firstScreenName, secondScreenName, thirdScreenName, forthScreenName)
    {
        FifthRecord = fifth;
        FifthUser = fifthUser;
        _fifthScreenName = fifthScreenName;

        FifthUser.Shift = Shift.GetCurrentShift();
    }

    public QualityControlBaseViewModel(OperationNames operationName,
                                        ScreenNames firstScreenName, ScreenNames secondScreenName, ScreenNames thirdScreenName, ScreenNames forthScreenName , ScreenNames fifthScreenName) : 
                                        base(operationName, firstScreenName, secondScreenName, thirdScreenName, forthScreenName)
    {
        FifthRecord = Activator.CreateInstance<T5>();
        if(FifthRecord == null)
            throw new NullReferenceException($"Property: {nameof(FifthRecord)} can't be null");
        FifthUser = new User();
        _fifthScreenName = fifthScreenName;

        FifthUser.Shift = Shift.GetCurrentShift();
    }

    [RelayCommand(CanExecute = nameof(CanSaveFifth))]
    private void SaveFifth()
    {
        if(FifthRecord != null)
        {
            ShiftPhase currentPhase = GetCurrentShiftPhase(FifthStartPhase, FifthMidPhase, FifthEndPhase);
            SaveRecord(_fifthScreenName.ToString(), FifthUser, FifthRecord, currentPhase, NoWorkActivatedForCurrentPhase(currentPhase, FifthNtOffStart, FifthNtOffMid, FifthNtOffEnd));
        }
        else
        {
            throw new NullReferenceException($"object {nameof(FifthRecord)} is null on method SaveFirst");
        }

        MovePhaseForward(RecordNumber.Fifth);

        SaveFifthCommand.NotifyCanExecuteChanged(); // disables the button after executing
    }

    /// <summary>
    /// Sets the disable property of the button validating the user input, with the current phase
    /// </summary>
    /// <returns>bool</returns>
    private bool CanSaveFifth() => CanSave(
        FifthUser, 
        FifthRecord!, 
        GetCurrentShiftPhase(FifthStartPhase, FifthMidPhase, FifthEndPhase),
        NoWorkActivatedForCurrentPhase(
            GetCurrentShiftPhase(FifthStartPhase, FifthMidPhase, FifthEndPhase),
            FifthNtOffStart,
            FifthNtOffMid,
            FifthNtOffEnd
        ));

    internal new void MovePhaseForward(RecordNumber recordNumber)
    {
        if(recordNumber == RecordNumber.Fifth)
        {
            FifthEndPhase = FifthMidPhase;
            FifthMidPhase = FifthStartPhase;
            FifthStartPhase = false;
        }
        else
            base.MovePhaseForward(recordNumber); // runs the base class method
        
    }

    internal new void SetNoTrabajo(RecordNumber r)
    {
        if(r == RecordNumber.Fifth)
        {
            if (FifthStartPhase)
            {
                ThirdNtOffStart = !FifthNtOffStart;
            }
            else if (FifthMidPhase)
            {
                FifthNtOffMid = !FifthNtOffMid;
            }
            else if (FifthEndPhase)
            {
                FifthNtOffEnd = !FifthNtOffEnd;
            }
            SaveFifthCommand.NotifyCanExecuteChanged();
        }
        else
            base.SetNoTrabajo(r);
    }

    [RelayCommand]
    private void ToggleNoTrabajoFifth()
    {
        SetNoTrabajo(RecordNumber.Fifth);
    }

}

public partial class QualityControlBaseViewModel<T1, T2, T3, T4, T5, T6> : QualityControlBaseViewModel<T1, T2, T3, T4, T5>
{
    [ObservableProperty]
    private T6 _sixthRecord;
    [ObservableProperty]
    private User _sixthUser;
    private ScreenNames _sixthScreenName;
    [ObservableProperty]
    private bool _sixthSaveIsEnabled = false;
    [ObservableProperty]
    private bool _sixthStartPhase = true;
    [ObservableProperty]
    private bool _sixthMidPhase = false;
    [ObservableProperty]
    private bool _sixthEndPhase = false;
    [ObservableProperty]
    private bool _sixthNtOffStart = true;
    [ObservableProperty]
    private bool _sixthNtOffMid = true;
    [ObservableProperty]
    private bool _sixthNtOffEnd = true;

    public QualityControlBaseViewModel(T1 first, User firstUser,
                                        T2 second, User secondUser, 
                                        T3 third, User thirdUser,
                                        T4 forth, User forthUser,
                                        T5 fifth, User fifthUser,
                                        T6 sixth, User sixthUser,
                                        OperationNames operationName,
                                        ScreenNames firstScreenName, ScreenNames secondScreenName, ScreenNames thirdScreenName, ScreenNames forthScreenName, ScreenNames fifthScreenName, ScreenNames sixthScreenName) : 
                                        base(first, firstUser, second, secondUser, third, thirdUser, forth, forthUser, fifth, fifthUser, operationName, firstScreenName, secondScreenName, thirdScreenName, forthScreenName, fifthScreenName)
    {
        SixthRecord = sixth;
        SixthUser = sixthUser;
        _sixthScreenName = sixthScreenName;

        SixthUser.Shift = Shift.GetCurrentShift();
    }

    public QualityControlBaseViewModel(OperationNames operationName,
                                        ScreenNames firstScreenName, ScreenNames secondScreenName, ScreenNames thirdScreenName, ScreenNames forthScreenName , ScreenNames fifthScreenName, ScreenNames sixthScreenName) : 
                                        base(operationName, firstScreenName, secondScreenName, thirdScreenName, forthScreenName, fifthScreenName)
    {
        SixthRecord = Activator.CreateInstance<T6>();
        SixthUser = new User();
        _sixthScreenName = sixthScreenName;

        SixthUser.Shift = Shift.GetCurrentShift();
    }

    [RelayCommand(CanExecute = nameof(CanSaveSixth))]
    private void SaveSixth()
    {
        if(SixthRecord != null)
        {
            ShiftPhase currentPhase = GetCurrentShiftPhase(SixthStartPhase, SixthMidPhase, SixthEndPhase);
            SaveRecord(_sixthScreenName.ToString(), SixthUser, SixthRecord, currentPhase, NoWorkActivatedForCurrentPhase(currentPhase, SixthNtOffStart, SixthNtOffMid, SixthNtOffEnd));
        }
        else
        {
            throw new NullReferenceException($"object {nameof(SixthRecord)} is null on method SaveFirst");
        }

        MovePhaseForward(RecordNumber.Sixth);

        SaveSixthCommand.NotifyCanExecuteChanged(); // disables the button after executing
    }

    /// <summary>
    /// Sets the disable property of the button validating the user input, with the current phase
    /// </summary>
    /// <returns>bool</returns>
    private bool CanSaveSixth() => CanSave(
        SixthUser, 
        SixthRecord!, 
        GetCurrentShiftPhase(SixthStartPhase, SixthMidPhase, SixthEndPhase),
        NoWorkActivatedForCurrentPhase(
            GetCurrentShiftPhase(SixthStartPhase, SixthMidPhase, SixthEndPhase),
            SixthNtOffStart,
            SixthNtOffMid,
            SixthNtOffEnd
        ));

    internal new void MovePhaseForward(RecordNumber recordNumber)
    {
        if(recordNumber == RecordNumber.Sixth)
        {
            SixthEndPhase = SixthMidPhase;
            SixthMidPhase = SixthStartPhase;
            SixthStartPhase = false;
        }
        else
            base.MovePhaseForward(recordNumber); // runs the base class method
        
    }

    internal new void SetNoTrabajo(RecordNumber r)
    {
        if(r == RecordNumber.Sixth)
        {
            if (SixthStartPhase)
            {
                ThirdNtOffStart = !SixthNtOffStart;
            }
            else if (SixthMidPhase)
            {
                SixthNtOffMid = !SixthNtOffMid;
            }
            else if (SixthEndPhase)
            {
                SixthNtOffEnd = !SixthNtOffEnd;
            }
            SaveSixthCommand.NotifyCanExecuteChanged();
        }
        else
            base.SetNoTrabajo(r);
    }

    [RelayCommand]
    private void ToggleNoTrabajoSixth()
    {
        SetNoTrabajo(RecordNumber.Sixth);
    }

}