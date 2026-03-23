using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Enums;
using FloorDigitalization.Helpers;
using FloorDigitalization.Models;
using FloorDigitalization.GenVPrincipal.Models;
using Serilog;

using FloorDigitalization.ViewModels;
namespace FloorDigitalization.GenVPrincipal.ViewModels;

public partial class GenVPrincipalAnillosViewModel : QualityControlBaseViewModel<Anillos, Anillos>
{
    public GenVPrincipalAnillosViewModel() : base(
                                                    OperationNames.GenVPrincipalAnillos,
                                                    ScreenNames.Anillos063,
                                                    ScreenNames.Anillos066)
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