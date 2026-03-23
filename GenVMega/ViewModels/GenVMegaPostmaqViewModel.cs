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
using FloorDigitalization.Static;

namespace FloorDigitalization.GenVMega.ViewModels;

public partial class GenVMegaPostmaqViewModel : QualityControlBaseViewModel<Postmaquinado, Postmaquinado>
{

    public GenVMegaPostmaqViewModel() : base(new Postmaquinado(), 
                                                            new User(), 
                                                            new Postmaquinado(), 
                                                            new User(), 
                                                            StaticFields.isPared ? OperationNames.GenVMegaPostmaquinadoPared : OperationNames.GenVMegaPostmaquinadoPasillo, 
                                                            StaticFields.isPared ? ScreenNames.Postmaquinado139Pared : ScreenNames.Postmaquinado138Pasillo, 
                                                            StaticFields.isPared ? ScreenNames.Postmaquinado142Pared : ScreenNames.Postmaquinado141Pasillo)
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

        // fileName1 = isPared ? "Postmaquinado139Pared" : "Postmaquinado138Pasillo";
        // fileName2 = isPared ? "Postmaquinado142Pared" : "Postmaquinado141Pasillo";
        
        // TabHeader1 = isPared ? "Postmaquinado 139" : "Postmaquinado 138";
        // TabHeader2 = isPared ? "Postmaquinado 142" : "Postmaquinado 141";
    }
}