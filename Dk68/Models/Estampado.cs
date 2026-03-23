using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Dk68.Models;

public partial class Estampado : ObservableValidator
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

    // ----------- DCP 53 -----------
    [ObservableProperty]
    private bool _dcp53Start;

    // ----------- DCP 58 -----------
    [ObservableProperty]
    private bool _dcp58Start;

    // ----------- DCP 57 -----------
    [ObservableProperty]
    private bool _dcp57Start;

    // ----------- DCP SN2 9 -----------
    [ObservableProperty]
    private bool _dcpSn2_9Start;
    [ObservableProperty]
    private bool _dcpSn2_9Mid;
    [ObservableProperty]
    private bool _dcpSn2_9End;
}