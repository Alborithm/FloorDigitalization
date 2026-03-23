using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Dk68.Models;

public partial class Balanceo : ObservableValidator
{
    // ----------- DCP 2 -----------
    [ObservableProperty]
    private bool _dcp2_1Start;
    [ObservableProperty]
    private bool _dcp2_1Mid;
    [ObservableProperty]
    private bool _dcp2_1End;
    // ----------- DCP 2 -----------
    [ObservableProperty]
    private bool _dcp2_2Start;
    [ObservableProperty]
    private bool _dcp2_2Mid;
    [ObservableProperty]
    private bool _dcp2_2End;

    // ----------- DCP 1 -----------
    [ObservableProperty]
    private bool _dcp1Start;
    [ObservableProperty]
    private bool _dcp1Mid;
    [ObservableProperty]
    private bool _dcp1End;

    // ----------- DCP 3 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(3.00, 99999.00, ErrorMessage = "Valor fuera de especificación (mayor a {1})")]
    private decimal? _dcp3Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(3.00, 99999.00, ErrorMessage = "Valor fuera de especificación (mayor a {1})")]
    private decimal? _dcp3Mid;

    // ----------- DCP SN 28 -----------
    [ObservableProperty]
    private bool _dcpSn28Start;
    [ObservableProperty]
    private bool _dcpSn28Mid;
    [ObservableProperty]
    private bool _dcpSn28End;

    // ----------- DCP 16 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.18, 0.18, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp16Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.18, 0.18, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp16Mid;

}