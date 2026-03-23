using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Dk68.Models;

public partial class Muesca : ObservableValidator
{
    // ----------- DCP 50 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(1.5, 2.5, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp50Start;

    // ----------- DCP 54 -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-3.00, 3.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp54Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-3.00, 3.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp54Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-3.00, 3.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp54End;

    // ----------- DCP 55 -----------
    [ObservableProperty]
    private bool _dcp55Start;
    [ObservableProperty]
    private bool _dcp55Mid;
    [ObservableProperty]
    private bool _dcp55End;
}