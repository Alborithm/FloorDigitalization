using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.GenVPrincipal.Models;

public partial class Cunero : ObservableValidator
{
    // ----------- DCP 47 -----------
    [ObservableProperty]
    private bool _dcp47Start;
    [ObservableProperty]
    private bool _dcp47Mid;
    [ObservableProperty]
    private bool _dcp47End;

    // ----------- DCP 50 48 -----------
    [ObservableProperty]
    private bool _dcp50_48Start;
    [ObservableProperty]
    private bool _dcp50_48Mid;
    [ObservableProperty]
    private bool _dcp50_48End;
    // ----------- DCP SN 77 -----------
    [ObservableProperty]
    private bool _dcpSn_77Start;
    [ObservableProperty]
    private bool _dcpSn_77Mid;
    [ObservableProperty]
    private bool _dcpSn_77End;
}