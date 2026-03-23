using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Dk68.Models;

public partial class Inspeccion : ObservableValidator
{
    // ----------- DCP 52 -----------
    [ObservableProperty]
    private bool _dcp52Start;
    [ObservableProperty]
    private bool _dcp52Mid;
    [ObservableProperty]
    private bool _dcp52End;

    // ----------- DCP 71 -----------
    [ObservableProperty]
    private bool _dcp71Start;
    [ObservableProperty]
    private bool _dcp71Mid;
    [ObservableProperty]
    private bool _dcp71End;
    
    // ----------- DCP 73 -----------
    [ObservableProperty]
    private bool _dcp73Start;
    [ObservableProperty]
    private bool _dcp73Mid;
    [ObservableProperty]
    private bool _dcp73End;
    
    // ----------- DCP 66 -----------
    [ObservableProperty]
    private bool _dcp66Start;
    [ObservableProperty]
    private bool _dcp66Mid;
    [ObservableProperty]
    private bool _dcp66End;

    // ----------- DCP 148 -----------
    [ObservableProperty]
    private bool _dcp148Start;
    [ObservableProperty]
    private bool _dcp148Mid;
    [ObservableProperty]
    private bool _dcp148End;

    // ----------- DCP 65 -----------
    [ObservableProperty]
    private bool _dcp65Start;
    [ObservableProperty]
    private bool _dcp65Mid;
    [ObservableProperty]
    private bool _dcp65End;

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

    // ----------- DCP 80 -----------
    [ObservableProperty]
    private bool _dcp80Start;
    [ObservableProperty]
    private bool _dcp80Mid;
    [ObservableProperty]
    private bool _dcp80End;

    // ----------- DCP 72 -----------
    [ObservableProperty]
    private bool _dcp72Start;
    [ObservableProperty]
    private bool _dcp72Mid;
    [ObservableProperty]
    private bool _dcp72End;

    // ----------- DCP 44 -----------
    [ObservableProperty]
    private bool _dcp44Start;
    [ObservableProperty]
    private bool _dcp44Mid;
    [ObservableProperty]
    private bool _dcp44End;

    // ----------- DCP SN2 9 -----------
    [ObservableProperty]
    private bool _dcpSn2_9Start;
    [ObservableProperty]
    private bool _dcpSn2_9Mid;
    [ObservableProperty]
    private bool _dcpSn2_9End;

    // ----------- DCP 30 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(17.045, 17.075, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp30Start;
}