
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.Models;

namespace FloorDigitalization.Multilinea.ViewModels;

public partial class MultilineaPC1TruckViewModel : QualityControlBaseViewModel<Op10HTruck, Op20HTruck, Op10WTruck, Op20WTruck, Op10ATruck>
{
    // This is Mazas, Anillos, Ensamble
    public MultilineaPC1TruckViewModel() : base(
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