using FloorDigitalization.Dk68.Models;
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;

namespace FloorDigitalization.Dk68.ViewModels;

public partial class Dk68PintadoEstampadoInspeccionViewModel : QualityControlBaseViewModel<Pintado, Estampado, Inspeccion>
{
    public Dk68PintadoEstampadoInspeccionViewModel() : base(new Pintado(), 
                                                    new User(),
                                                    new Estampado(),
                                                    new User(),
                                                    new Inspeccion(),
                                                    new User(),
                                                    OperationNames.Dk68EnsambleLavadora,  //   TODO: CHANGE THIS LATER WHEN WE HAVE THE MACHINES AND THE ONE DRIVE LOCATION
                                                    ScreenNames.Pintado,
                                                    ScreenNames.Estampado,
                                                    ScreenNames.Inspeccion)
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