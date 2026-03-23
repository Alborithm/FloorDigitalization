using FloorDigitalization.Dk68.Models;
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;

namespace FloorDigitalization.Dk68.ViewModels;

public partial class Dk68EpcViewModel : QualityControlBaseViewModel<Epc>
{
    public Dk68EpcViewModel() : base(new Epc(), 
                                                    new User(),
                                                    OperationNames.Dk68EnsambleLavadora, //TODO: Change when we have the route of the computers
                                                    ScreenNames.Epc)
    {
        FirstRecord.PropertyChanged += (sender, e) =>
        {
            SaveFirstCommand.NotifyCanExecuteChanged();
        };
        FirstUser.PropertyChanged += (sender, e) =>
        {
            SaveFirstCommand.NotifyCanExecuteChanged();
        };
    }
}