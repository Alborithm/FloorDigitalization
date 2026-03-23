using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Dk68.Models;

public partial class Ensamble : ObservableValidator
{
    // ----------- DCP 30 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.35, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp30Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.35, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp30Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.35, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp30End;

    // ----------- DCP 21 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.35, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp21Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.35, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp21Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.35, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp21End;

    // ----------- DCP 19 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.35, 0.35, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp19Start;

    // ----------- DCP SN 30 -----------
    [ObservableProperty]
    private bool _dcpSn30Start;
    [ObservableProperty]
    private bool _dcpSn30Mid;
    [ObservableProperty]
    private bool _dcpSn30End;

    // ----------- DCP 73 -----------
    [ObservableProperty]
    private bool _dcp73Start;
    [ObservableProperty]
    private bool _dcp73Mid;
    [ObservableProperty]
    private bool _dcp73End;
}