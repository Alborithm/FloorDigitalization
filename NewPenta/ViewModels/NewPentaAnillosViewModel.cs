using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Enums;
using FloorDigitalization.Helpers;
using FloorDigitalization.Models;
using FloorDigitalization.NewPenta.Models;
using Serilog;

using FloorDigitalization.ViewModels;
namespace FloorDigitalization.NewPenta.ViewModels;

public partial class NewPentaAnillosViewModel : QualityControlBaseViewModel<Anillos, Anillos, Anillos, Anillos, Anillos, Anillos>
{
    public NewPentaAnillosViewModel() : base(
                                                    OperationNames.NewPentaAnillos,
                                                    ScreenNames.NewPentaAnillosPTN116,
                                                    ScreenNames.NewPentaAnillosPTN086,
                                                    ScreenNames.NewPentaAnillosPTN109,
                                                    ScreenNames.NewPentaAnillosPTN103,
                                                    ScreenNames.NewPentaAnillosPTN106,
                                                    ScreenNames.NewPentaAnillosPTN115)
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
        FifthRecord.PropertyChanged += (sender, e) =>
        {
            SaveFifthCommand.NotifyCanExecuteChanged();
        };
        FifthUser.PropertyChanged += (sender, e) =>
        {
            SaveFifthCommand.NotifyCanExecuteChanged();
        };
        SixthRecord.PropertyChanged += (sender, e) =>
        {
            SaveSixthCommand.NotifyCanExecuteChanged();
        };
        SixthUser.PropertyChanged += (sender, e) =>
        {
            SaveSixthCommand.NotifyCanExecuteChanged();
        };
    }
}