using FloorDigitalization.Dk68.Models;
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.Enums;

namespace FloorDigitalization.Dk68.ViewModels;

public partial class Dk68MuescaBalanceoLavadoraViewModel : QualityControlBaseViewModel<Muesca, Balanceo, Balanceo, Op50A>
{
    public Dk68MuescaBalanceoLavadoraViewModel() : base(new Muesca(), 
                                                    new User(),
                                                    new Balanceo(),
                                                    new User(),
                                                    new Balanceo(),
                                                    new User(),
                                                    new Op50A(),
                                                    new User(),
                                                    OperationNames.Dk68EnsambleLavadora,  //   TODO: CHANGE THIS LATER WHEN WE HAVE THE MACHINES AND THE ONE DRIVE LOCATION
                                                    ScreenNames.Muesca,
                                                    ScreenNames.BalanceoPBL038,
                                                    ScreenNames.BalanceoPBL023,
                                                    ScreenNames.PVL006)
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
    }
}