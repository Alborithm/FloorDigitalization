
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.Models.Ctsv;

namespace FloorDigitalization.Multilinea.ViewModels;

public partial class MultilineaPC4CtsvViewModel : QualityControlBaseViewModel<Op100ACtsv, Op110ACtsv>
{
    // This is Mazas, Anillos, Ensamble
    public MultilineaPC4CtsvViewModel() : base(
                                                    OperationNames.MultilineaPC4, 
                                                    ScreenNames.MultilineaCtsv100A,
                                                    ScreenNames.MultilineaCtsv110A)
    {
        FirstRecord.PropertyChanged += (sender, e) =>
        {
            SaveFirstCommand.NotifyCanExecuteChanged();
        };
        FirstUser.PropertyChanged += (sender, e) =>
        {
            SaveFirstCommand.NotifyCanExecuteChanged();
        };
        SecondRecord.PropertyChanged += (sender, e) =>
        {
            SaveSecondCommand.NotifyCanExecuteChanged();
        };
        SecondUser.PropertyChanged += (sender, e) =>
        {
            SaveSecondCommand.NotifyCanExecuteChanged();
        };
        // ThirdRecord.PropertyChanged += (sender, e) =>
        // {
        //     SaveThirdCommand.NotifyCanExecuteChanged();
        // };
        // ThirdUser.PropertyChanged += (sender, e) =>
        // {
        //     SaveThirdCommand.NotifyCanExecuteChanged();
        // };
        // ForthRecord.PropertyChanged += (sender, e) =>
        // {
        //     SaveForthCommand.NotifyCanExecuteChanged();
        // };
        // ForthUser.PropertyChanged += (sender, e) =>
        // {
        //     SaveForthCommand.NotifyCanExecuteChanged();
        // };
        // FifthRecord.PropertyChanged += (sender, e) =>
        // {
        //     SaveFifthCommand.NotifyCanExecuteChanged();
        // };
        // FifthUser.PropertyChanged += (sender, e) =>
        // {
        //     SaveFifthCommand.NotifyCanExecuteChanged();
        // };
    }
}