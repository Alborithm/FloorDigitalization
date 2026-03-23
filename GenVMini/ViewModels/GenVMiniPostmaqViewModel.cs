using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.Helpers;
using FloorDigitalization.GenVMini.Models;
using FloorDigitalization.Models;
using Serilog;
using FloorDigitalization.ViewModels;
using System.Collections.ObjectModel;
using FloorDigitalization.Enums;
using FloorDigitalization.Helpers.Views;

namespace FloorDigitalization.GenVMini.ViewModels;

public partial class GenVMiniPostmaqViewModel : QualityControlBaseViewModel<Postmaquinado, Postmaquinado>
{
    public GenVMiniPostmaqViewModel() : base(
                                                    OperationNames.GenVMiniPostmaquinado,
                                                    ScreenNames.Postmaquinado101,
                                                    ScreenNames.Postmaquinado113)
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