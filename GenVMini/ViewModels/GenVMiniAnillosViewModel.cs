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

public partial class GenVMiniAnillosViewModel : QualityControlBaseViewModel<Anillos, Anillos>
{
    public GenVMiniAnillosViewModel() : base(
                                                    OperationNames.GenVMiniAnillos,
                                                    ScreenNames.AnillosPTN111,
                                                    ScreenNames.AnillosPTN112)
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