using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.GenVPrincipal.Models;

public partial class Pulido : ObservableValidator
{
    // ----------- DCP SN01 -----------
    [ObservableProperty]
    private bool _dcpSn01Start;

    [ObservableProperty]
    private bool _dcpSn01Mid;

    // ----------- DCP 36A -----------
    [ObservableProperty]
    private bool _dcp36aStart;
    [ObservableProperty]
    private bool _dcp36aMid;
    [ObservableProperty]
    private bool _dcp36aEnd;
    
    // ----------- DCP 36B -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(37.600, 37.625, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp36b_1Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(37.600, 37.625, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp36b_1Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(37.600, 37.625, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp36b_1End;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(37.600, 37.625, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp36b_2Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(37.600, 37.625, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp36b_2Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(37.600, 37.625, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp36b_2End;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(37.600, 37.625, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp36b_3Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(37.600, 37.625, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp36b_3Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(37.600, 37.625, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp36b_3End;

    // ----------- DCP 19 -----------
    [ObservableProperty]
    private bool _dcp19Start;
    [ObservableProperty]
    private bool _dcp19Mid;
    [ObservableProperty]
    private bool _dcp19End;

    // ----------- DCP 20 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.25, 0.8, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp20_1Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.25, 0.8, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp20_1Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.25, 0.8, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp20_1End;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.25, 0.8, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp20_2Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.25, 0.8, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp20_2Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.25, 0.8, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp20_2End;
    
    // ----------- DCP 15 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.065, 0.065, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp15Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.065, 0.065, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp15Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.065, 0.065, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp15End;

    // ----------- DCP SN 10 -----------
    [ObservableProperty]
    private bool _dcpSn_10Start;
    [ObservableProperty]
    private bool _dcpSn_10Mid;
    [ObservableProperty]
    private bool _dcpSn_10End;

    // ----------- DCP 77 161  -----------
    [ObservableProperty]
    private bool _dcp77_161Start;
    [ObservableProperty]
    private bool _dcp77_161Mid;
    [ObservableProperty]
    private bool _dcp77_161End;
}