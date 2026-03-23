using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Helpers;
using FloorDigitalization.GenVMega.Models;
using FloorDigitalization.Models;
using Serilog;
using FloorDigitalization.ViewModels;
using System.Collections.ObjectModel;
using FloorDigitalization.Enums;

namespace FloorDigitalization.GenVMega.ViewModels;

public partial class GenVMegaPulidoCuneroViewModel : QualityControlBaseViewModel<Cunero, Pulido, Prelavadora>
{

    public GenVMegaPulidoCuneroViewModel() : base(
                                            OperationNames.GenVMegaPulidoCunero, 
                                            ScreenNames.Cunero,
                                            ScreenNames.Pulido, 
                                            ScreenNames.Prelavadora)
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