
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.Models;

namespace FloorDigitalization.Multilinea.ViewModels;

public partial class MultilineaCtsv10HViewModel : QualityControlBaseViewModel<Op10HCtsv>
{
    public MultilineaCtsv10HViewModel() : base(
                                                    OperationNames.DebugPc, 
                                                    ScreenNames.MultilineaCtsv10H)
    {
        FirstRecord.PropertyChanged += (sender, e) =>
        {
            SaveFirstCommand.NotifyCanExecuteChanged();
        };
        FirstUser.PropertyChanged += (sender, e) =>
        {
            SaveFirstCommand.NotifyCanExecuteChanged();
        };
        // SecondRecord.PropertyChanged += (sender, e) =>
        // {
        //     SaveSecondCommand.NotifyCanExecuteChanged();
        // };
        // SecondUser.PropertyChanged += (sender, e) =>
        // {
        //     SaveSecondCommand.NotifyCanExecuteChanged();
        // };
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