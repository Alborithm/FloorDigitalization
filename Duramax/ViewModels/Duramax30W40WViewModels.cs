
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;
using FloorDigitalization.Duramax.Models;

namespace FloorDigitalization.Duramax.ViewModels;

public partial class Duramax30W40WViewModel : QualityControlBaseViewModel<Op30WCara1, Op30WCara2, Op30WCara1, Op30WCara2, Balanceo40W, Balanceo40W>
{
    public Duramax30W40WViewModel() : base(
        OperationNames.DebugPc, 
        ScreenNames.MaquinadoPCM065Cara1,
        ScreenNames.MaquinadoPCM065Cara2,
        ScreenNames.MaquinadoPCM066Cara1,
        ScreenNames.MaquinadoPCM066Cara2,
        ScreenNames.BalanceoPBL035,
        ScreenNames.BalanceoPBL014)
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
        ThirdRecord.PropertyChanged += (sender, e) =>
        {
            SaveThirdCommand.NotifyCanExecuteChanged();
        };
        ThirdUser.PropertyChanged += (sender, e) =>
        {
            SaveThirdCommand.NotifyCanExecuteChanged();
        };
        ForthRecord.PropertyChanged += (sender, e) =>
        {
            SaveForthCommand.NotifyCanExecuteChanged();
        };
        ForthUser.PropertyChanged += (sender, e) =>
        {
            SaveForthCommand.NotifyCanExecuteChanged();
        };
        FifthRecord.PropertyChanged += (sender, e) =>
        {
            SaveFifthCommand.NotifyCanExecuteChanged();
        };
        FifthUser.PropertyChanged += (sender, e) =>
        {
            SaveFifthCommand.NotifyCanExecuteChanged();
        };
        SixthRecord.PropertyChanged += (sender, e) =>
        {
            SaveSixthCommand.NotifyCanExecuteChanged();
        };
        SixthUser.PropertyChanged += (sender, e) =>
        {
            SaveSixthCommand.NotifyCanExecuteChanged();
        };
    }
}