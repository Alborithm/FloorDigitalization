using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Helpers;
using FloorDigitalization.Models;
using FloorDigitalization.ViewModels;
using FloorDigitalization.GenVMega.Models;
using Serilog;
using FloorDigitalization.Enums;
using FloorDigitalization.Static;

namespace FloorDigitalization.GenVMega.ViewModels;

public partial class GenVMegaMazasEnsambleViewModel : QualityControlBaseViewModel<Mazas, Mazas, Ensamble>
{
    public GenVMegaMazasEnsambleViewModel() : base(
                                                    StaticFields.isPared ? OperationNames.GenVMegaMazasEnsamblePared : OperationNames.GenVMegaMazasEnsamblePasillo,
                                                    StaticFields.isPared ? ScreenNames.Mazas134Pared : ScreenNames.Mazas126Pasillo,
                                                    StaticFields.isPared ? ScreenNames.Mazas135Pared : ScreenNames.Mazas127Pasillo,
                                                    StaticFields.isPared ? ScreenNames.Ensamble038 : ScreenNames.Ensamble042)
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