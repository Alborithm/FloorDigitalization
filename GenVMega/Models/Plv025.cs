using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.GenVMega.Models;

public partial class Plv025 : ObservableValidator
{
    // ----------- Concentracion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(20.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _concentracionStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(20.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _concentracionMid;
    // ----------- PH ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(9.00, 99999.00, ErrorMessage = "Valor fuera de especificación (mayor o igual a {1})")]
    private decimal? _phStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(9.00, 99999.00, ErrorMessage = "Valor fuera de especificación (mayor o igual a {1})")]
    private decimal? _phMid;
    // ----------- Tempreatura ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(40.00, 55.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _temperaturaStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _nivelStart;
    
    // ----------- Limpieza ----------- 
    [ObservableProperty]
    private bool _limpiezaStart;
}