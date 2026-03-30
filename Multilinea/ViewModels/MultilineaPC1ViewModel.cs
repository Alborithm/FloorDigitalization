
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.Models;

namespace FloorDigitalization.Multilinea.ViewModels;

public partial class MultilineaPC1ViewModel : QualityControlBaseViewModel<Op10HTruck, Op20HTruck>
{
    // This is Mazas, Anillos, Ensamble
    public MultilineaPC1ViewModel() : base(
                                                    OperationNames.DebugPc, 
                                                    ScreenNames.MultilineaTruck10H,
                                                    ScreenNames.MultilineaTruck20H)
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
    }
}