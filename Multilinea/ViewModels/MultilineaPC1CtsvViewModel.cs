
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.Models;
using FloorDigitalization.Multilinea.Models.Ctsv;

namespace FloorDigitalization.Multilinea.ViewModels;

public partial class MultilineaPC1CtsvViewModel : QualityControlBaseViewModel<Op10HCtsv, Op20HTruck, Op10WTruck, Op20WTruck, Op10ATruck>
{
    // This is Mazas, Anillos, Ensamble
    public MultilineaPC1CtsvViewModel() : base(
                                                    OperationNames.DebugPc, 
                                                    ScreenNames.MultilineaTruck10H,
                                                    ScreenNames.MultilineaTruck20H,
                                                    ScreenNames.MultilineaTruck10W,
                                                    ScreenNames.MultilineaTruck20W,
                                                    ScreenNames.MultilineaTruck10A)
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