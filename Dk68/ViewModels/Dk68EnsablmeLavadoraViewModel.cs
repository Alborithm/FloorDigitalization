
using FloorDigitalization.Dk68.Models;
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;

namespace FloorDigitalization.Dk68.ViewModels;

public partial class Dk68EnsambleLavadoraViewModel : QualityControlBaseViewModel<Ensamble, Prelavadora>
{
    public Dk68EnsambleLavadoraViewModel() : base(new Ensamble(), 
                                                    new User(),
                                                    new Prelavadora(),
                                                    new User(),
                                                    OperationNames.Dk68EnsambleLavadora, 
                                                    ScreenNames.Ensamble,
                                                    ScreenNames.Prelavadora)
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
    }
}