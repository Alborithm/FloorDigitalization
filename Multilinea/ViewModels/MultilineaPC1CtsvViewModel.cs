
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.Models.Ctsv;

namespace FloorDigitalization.Multilinea.ViewModels;

public partial class MultilineaPC1CtsvViewModel : QualityControlBaseViewModel<Op10WCtsv, Op20WCtsv, Op10HCtsv, Op20HCtsv, Op20ACtsv>
{
    // This is Mazas, Anillos, Ensamble
    public MultilineaPC1CtsvViewModel() : base(
                                                    OperationNames.MultilineaPC1, 
                                                    ScreenNames.MultilineaCtsv10W,
                                                    ScreenNames.MultilineaCtsv20W,
                                                    ScreenNames.MultilineaCtsv10H,
                                                    ScreenNames.MultilineaCtsv20H,
                                                    ScreenNames.MultilineaCtsv20A)
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
    }
}