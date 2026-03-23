using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Helpers;
using FloorDigitalization.GenVMini.Models;
using FloorDigitalization.Models;
using Serilog;
using FloorDigitalization.ViewModels;
using System.Collections.ObjectModel;
using FloorDigitalization.Enums;

namespace FloorDigitalization.GenVMini.ViewModels;

public partial class GenVMiniPulidoCuneroBalanceoViewModel : QualityControlBaseViewModel<Cunero, Pulido, Balanceo, Balanceo>
{
    public GenVMiniPulidoCuneroBalanceoViewModel() : base(
                                                    new Cunero(),
                                                    new User(),
                                                    new Pulido(),
                                                    new User(),
                                                    new Balanceo(),
                                                    new User(),
                                                    new Balanceo(),
                                                    new User(),
                                                    OperationNames.GenVMiniPulidoCuneroBalanceo,
                                                    ScreenNames.Cunero,
                                                    ScreenNames.Pulido,
                                                    ScreenNames.BalanceoPBL030,
                                                    ScreenNames.BalanceoPBL039)
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