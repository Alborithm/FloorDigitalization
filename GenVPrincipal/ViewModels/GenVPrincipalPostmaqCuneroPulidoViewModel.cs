using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Helpers;
using FloorDigitalization.GenVPrincipal.Models;
using FloorDigitalization.Models;
using Serilog;
using FloorDigitalization.ViewModels;
using System.Collections.ObjectModel;
using FloorDigitalization.Enums;

namespace FloorDigitalization.GenVPrincipal.ViewModels;

public partial class GenVPrincipalPostmaqCuneroPulidoViewModel : QualityControlBaseViewModel<Postmaquinado, Cunero, Pulido>
{
    public GenVPrincipalPostmaqCuneroPulidoViewModel() : base (OperationNames.GenVPrincipalPostmaquinadoPulidoCunero,
                                                        ScreenNames.Postmaquinado,
                                                        ScreenNames.Cunero,
                                                        ScreenNames.Pulido)
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