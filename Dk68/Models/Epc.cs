using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Dk68.Models;

public partial class Epc : ObservableValidator
{
    // ----------- DCP 52 -----------
    [ObservableProperty]
    private bool _dcp52Start;
    [ObservableProperty]
    private bool _dcp52Mid;
    [ObservableProperty]
    private bool _dcp52End;
    
    // ----------- DCP 73 -----------
    [ObservableProperty]
    private bool _dcp73Start;
    [ObservableProperty]
    private bool _dcp73Mid;
    [ObservableProperty]
    private bool _dcp73End;
    
    // Not required according to update from ana on April 2026
    // ----------- DCP 68 -----------
    // [ObservableProperty]
    // private bool _dcp68Start;
    // [ObservableProperty]
    // private bool _dcp68Mid;
    // [ObservableProperty]
    // private bool _dcp68End;

    // ----------- DCP 80 -----------
    [ObservableProperty]
    private bool _dcp80Start;
    [ObservableProperty]
    private bool _dcp80Mid;
    [ObservableProperty]
    private bool _dcp80End;

    // ----------- DCP SN 31 -----------
    [ObservableProperty]
    private bool _dcpSn31Start;
    [ObservableProperty]
    private bool _dcpSn31Mid;
    [ObservableProperty]
    private bool _dcpSn31End;

    // ----------- DCP 71 -----------
    [ObservableProperty]
    private bool _dcp71Start;
    [ObservableProperty]
    private bool _dcp71Mid;
    [ObservableProperty]
    private bool _dcp71End;

    // ----------- DCP 148 -----------
    [ObservableProperty]
    private bool _dcp148Start;
    [ObservableProperty]
    private bool _dcp148Mid;
    [ObservableProperty]
    private bool _dcp148End;

    // ----------- DCP SN 28 -----------
    [ObservableProperty]
    private bool _dcpSn28Start;
    [ObservableProperty]
    private bool _dcpSn28Mid;
    [ObservableProperty]
    private bool _dcpSn28End;

    // ----------- DCP 72 -----------
    [ObservableProperty]
    private bool _dcp72Start;
    [ObservableProperty]
    private bool _dcp72Mid;
    [ObservableProperty]
    private bool _dcp72End;
}