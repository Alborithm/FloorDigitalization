using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.GenVMini.Models;

public partial class Pulido : ObservableValidator
{
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
    
    // ----------- DCP SN 10 -----------
    [ObservableProperty]
    private bool _dcpSn_10Start;
    [ObservableProperty]
    private bool _dcpSn_10Mid;
    [ObservableProperty]
    private bool _dcpSn_10End;
}