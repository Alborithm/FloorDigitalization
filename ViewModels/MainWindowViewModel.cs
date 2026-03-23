using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FloorDigitalization.GenVPrincipal.ViewModels;
using FloorDigitalization.GenVMega.ViewModels;
using FloorDigitalization.GenVMini.ViewModels;
using FloorDigitalization.Models;
using Serilog;
using FloorDigitalization.L625.ViewModels;
using FloorDigitalization.Helpers;
using FloorDigitalization.Dk68.ViewModels;
using FloorDigitalization.Duramax.ViewModels;
using System.Reflection;

namespace FloorDigitalization.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    // private string route = "C:\\Users\\slp.wkstn28\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - L625\\";
    // private string route = "C:\\Users\\gerardo.albor\\OneDrive - MUVIQ S.R.L\\SLP Floor Digitalization - Documentos\\Calidad\\ControlCalidad\\L625\\";

    public ViewModelBase CurrentPage { get; set; }
    

    [ObservableProperty]
    private User _user = new User();
    [ObservableProperty]
    private string _date = DateTime.Today.ToShortDateString();
    

    [ObservableProperty]
    private bool _isRefreshing;

    // Public property to expose the version information
    public string Version
    {
        get
        {
            // Retrieve the version from the executing assembly
            Version version = Assembly.GetExecutingAssembly().GetName().Version ?? new ();
            return $"Version {version?.Major}.{version?.Minor}.{version?.Build}";
        }
    }

    partial void OnIsRefreshingChanged(bool value)
    {
        // Todo: this is for clearing the screen with the cambio de turno button, seems to be not working it freezes the upload button
        // Could be because not setting the current phase validation to start back again
        if (value)
        {
            InitData();
            OnPropertyChanged(string.Empty);
            IsRefreshing = false;
        }
    }


    // public MainWindowViewModel(L625PostmaqViewModel l625Postmaq,
    //     L625BalanceoInspeccionViewModel l625BalanceoInspeccion,
    //     GenVPrincipalAnillosViewModel genVPrincipalAnillos,
    //     GenVPrincipalMazasEnsambleViewModel genVPrincipalMazasEnsamble,
    //     GenVPrincipalPostmaqCuneroPulidoViewModel genVPrincipalPostmaqCuneroPulido,
    //     GenVPrincipalBalanceoPinturaViewModel genVPrincipalBalanceoPinturaViewModel,
    //     GenVMegaPostmaqViewModel genVMegaPostmaqViewModel,
    //     GenVMegaMazasEnsambleViewModel genVMegaMazasEnsambleViewModel,
    //     GenVMegaAnillosViewModel genVMegaAnillosViewModel,
    //     GenVMegaPulidoCuneroViewModel genVMegaPulidoCuneroViewModel,
    //     GenVMegaBalanceoPinturaViewModel genVMegaBalanceoPinturaViewModel,
    //     GenVMiniAnillosViewModel genVMiniAnillosViewModel,
    //     GenVMiniMazasEnsambleViewModel genVMiniMazasEnsambleViewModel,
    //     GenVMiniPostmaqViewModel genVMiniPostmaqViewModel,
    //     GenVMiniPulidoCuneroBalanceoViewModel genVMiniPulidoCuneroBalanceoViewModel,
    //     Dk68EnsambleLavadoraViewModel
    //     Dk68MuescaBalanceoLavadoraViewModel
    //     Dk68PintadoEstampadoInspeccionViewModel
    //     Dk68EpcViewModel
    //     Duramax10w20w25wViewModel
    //     Duramax30W40WViewModel
    //     )
    // {
    //     CurrentPage = l625BalanceoInspeccion;


    //     // set Shift
    //     int currentShift = GetCurrentShift();
    //     User.Shift = currentShift;
    // }
    public MainWindowViewModel(
        GenVMiniPostmaqViewModel viewModel
        )
    {
        CurrentPage = viewModel;

        // set Shift
        User.Shift = Shift.GetCurrentShift();
    }

    private void InitData()
    {
        Log.Information("Main View Data Initialized");
        User.Shift = Shift.GetCurrentShift();
    }

    [RelayCommand]
    private void Refresh()
    {
        IsRefreshing = true;
    }
}
