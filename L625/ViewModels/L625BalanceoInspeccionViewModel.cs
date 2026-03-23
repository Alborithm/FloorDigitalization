
using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Enums;
using FloorDigitalization.Helpers;
using FloorDigitalization.Helpers.Views;
using FloorDigitalization.L625.Models;
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using Serilog;

namespace FloorDigitalization.L625.ViewModels;

public partial class L625BalanceoInspeccionViewModel : QualityControlBaseViewModel<Balanceo, Inspeccion>
{

    public L625BalanceoInspeccionViewModel() : base(new Balanceo(), new User(), new Inspeccion(), new User(), OperationNames.L625BalanceoInspeccion, ScreenNames.Balanceo, ScreenNames.Inspeccion)
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