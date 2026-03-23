using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Dk68.Models;

public partial class Pintado : ObservableValidator
{
    // ----------- DCP SN 23 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(2.0, 5.0, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn23Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(2.0, 5.0, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn23Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(2.0, 5.0, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn23End;

    // ----------- DCP 66 -----------
    [ObservableProperty]
    private bool _dcp66Start;
    [ObservableProperty]
    private bool _dcp66Mid;
    [ObservableProperty]
    private bool _dcp66End;

    // ----------- DCP SN 27 -----------
    // TODO: This should be only asked by demand
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(32.0, 38.0, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn27Start;

    // ----------- DCP 65 -----------
    [ObservableProperty]
    private bool _dcp65Start;
    [ObservableProperty]
    private bool _dcp65Mid;
    [ObservableProperty]
    private bool _dcp65End;
}