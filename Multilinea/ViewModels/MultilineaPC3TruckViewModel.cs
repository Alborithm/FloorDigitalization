
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;
using FloorDigitalization.Multilinea.Models.Truck;

namespace FloorDigitalization.Multilinea.ViewModels;

public partial class MultilineaPC3TruckViewModel : QualityControlBaseViewModel<Op60ATruck>
{
    // This is Mazas, Anillos, Ensamble
    public MultilineaPC3TruckViewModel() : base(
                                                    OperationNames.MultilineaPC3, 
                                                    ScreenNames.MultilineaTruck60A)
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