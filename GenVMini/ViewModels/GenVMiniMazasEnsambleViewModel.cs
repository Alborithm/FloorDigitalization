using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Helpers;
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.GenVMini.Models;
using Serilog;
using FloorDigitalization.Enums;

namespace FloorDigitalization.GenVMini.ViewModels;

public partial class GenVMiniMazasEnsambleViewModel : QualityControlBaseViewModel<Mazas, Mazas, Ensamble>
{
    public GenVMiniMazasEnsambleViewModel() : base(
                                                    OperationNames.GenVMiniMazasEnsamble,
                                                    ScreenNames.MazasPTN102,
                                                    ScreenNames.MazasPTN089,
                                                    ScreenNames.Ensamble)
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