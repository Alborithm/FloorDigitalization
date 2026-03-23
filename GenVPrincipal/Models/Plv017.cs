using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.GenVPrincipal.Models;

public partial class Plv017 : ObservableValidator
{
    // ----------- Concentracion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(20, 30, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _concentracionStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(20, 30, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _concentracionMid;
    // ----------- PH ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(9, 99999, ErrorMessage = "Valor fuera de especificación (mayor o igual a {2})")]
    private decimal? _phStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(9, 99999, ErrorMessage = "Valor fuera de especificación (mayor o igual a {2})")]
    private decimal? _phMid;
    // ----------- Tempreatura ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(40, 55, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _temperaturaStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _nivelStart;
    
    // ----------- Limpieza ----------- 
    [ObservableProperty]
    private bool _limpiezaStart;
}