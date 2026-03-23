using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Dk68.Models;

public partial class Prelavadora : ObservableValidator
{
    // ----------- Concentracion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(7.00, 10.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _alcalinidadStart;

    // ----------- PH ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(40.00, 55.00, ErrorMessage = "Valor fuera de especificación (mayor o igual a {2})")]
    private decimal? _temperaturaStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _nivelStart;
}