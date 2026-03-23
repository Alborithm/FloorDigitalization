using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Helpers;
using FloorDigitalization.Models;
using FloorDigitalization.L625.Models;
using Serilog;
using FloorDigitalization.Enums;
using FloorDigitalization.ViewModels;

namespace FloorDigitalization.L625.ViewModels;

public partial class L625PostmaqViewModel : QualityControlBaseViewModel<Ensamble, Postmaquinado, Pulido, Cunero>
{
    public L625PostmaqViewModel() : base(new Ensamble(), 
                                                    new User(),
                                                    new Postmaquinado(),
                                                    new User(),
                                                    new Pulido(),
                                                    new User(),
                                                    new Cunero(),
                                                    new User(),
                                                    OperationNames.L625Postmaquinado,
                                                    ScreenNames.Ensamble,
                                                    ScreenNames.Postmaquinado,
                                                    ScreenNames.Pulido,
                                                    ScreenNames.Cunero)
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