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
    
    // ----------- DCP 68 -----------
    [ObservableProperty]
    private bool _dcp68Start;
    [ObservableProperty]
    private bool _dcp68Mid;
    [ObservableProperty]
    private bool _dcp68End;

    // ----------- DCP 82 -----------
    [ObservableProperty]
    private bool _dcp82Start;
    [ObservableProperty]
    private bool _dcp82Mid;
    [ObservableProperty]
    private bool _dcp82End;

    // ----------- DCP SN -----------
    [ObservableProperty]
    private bool _dcpSnStart;
    [ObservableProperty]
    private bool _dcpSnMid;
    [ObservableProperty]
    private bool _dcpSnEnd;

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