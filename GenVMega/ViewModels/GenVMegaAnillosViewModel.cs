using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Helpers;
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.GenVMega.Models;
using FloorDigitalization.Enums;
using Serilog;
using FloorDigitalization.Static;
using Avalonia.Platform;

namespace FloorDigitalization.GenVMega.ViewModels;

public partial class GenVMegaAnillosViewModel : QualityControlBaseViewModel<Anillos, Anillos>
{
    public GenVMegaAnillosViewModel() : base(
                                                    StaticFields.isPared ? OperationNames.GenVMegaAnillosPared : OperationNames.GenVMegaAnillosPasillo,
                                                    StaticFields.isPared ? ScreenNames.Anillos131Pared : ScreenNames.Anillos128Pasillo,
                                                    StaticFields.isPared ? ScreenNames.Anillos132Pared : ScreenNames.Anillos144Pasillo)
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