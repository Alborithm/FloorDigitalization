
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;
using FloorDigitalization.Duramax.Models;

namespace FloorDigitalization.Duramax.ViewModels;

public partial class Duramax10w20w25wViewModel : QualityControlBaseViewModel<Op10W20W, Op10W20W, Estampado>
{
    public Duramax10w20w25wViewModel() : base(
                                                    OperationNames.DebugPc, 
                                                    ScreenNames.MaquinadoPTN010,
                                                    ScreenNames.MaquinadoPTN017,
                                                    ScreenNames.Estampado)
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
    }
}