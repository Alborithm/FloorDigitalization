using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.GenVMini.Models;

public partial class Balanceo : ObservableValidator
{
    // ----------- DCP 71 ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 180, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp71Start;

    // ----------- DCP 3 ----------- 
    [ObservableProperty]
    private bool _dcp3Start;
    [ObservableProperty]
    private bool _dcp3Mid;
    [ObservableProperty]
    private bool _dcp3End;

    // ----------- DCP 53 ----------- 
    [ObservableProperty]
    private bool _dcp53Start;
    [ObservableProperty]
    private bool _dcp53Mid;
    [ObservableProperty]
    private bool _dcp53End;

    // ----------- DCP 54 ----------- 
    [ObservableProperty]
    private bool _dcp54Start;
    [ObservableProperty]
    private bool _dcp54Mid;
    [ObservableProperty]
    private bool _dcp54End;

}