using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.GenVPrincipal.Models;

public partial class Pintura : ObservableValidator
{
    // ----------- DCP SN 31 ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(2.0, 5.0, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn_31_1Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(2.0, 5.0, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn_31_1End;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(2.0, 5.0, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn_31_2Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(2.0, 5.0, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn_31_2End;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(2.0, 5.0, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn_31_3Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(2.0, 5.0, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn_31_3End;

    // ----------- DCP SN 34 ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(32, 38, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn_34Any;

    // ----------- DCP 77 ----------- 
    [ObservableProperty]
    private bool _dcp77Start;
    [ObservableProperty]
    private bool _dcp77Mid;
    [ObservableProperty]
    private bool _dcp77End;

    // ----------- DCP 65 DCP 67 ----------- 
    [ObservableProperty]
    private bool _dcp65_67Start;
    [ObservableProperty]
    private bool _dcp65_67Mid;
    [ObservableProperty]
    private bool _dcp65_67End;

}