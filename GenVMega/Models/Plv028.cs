using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.GenVMega.Models;

public partial class Plv028 : ObservableValidator
{
    // ----------- Concentracion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(20.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina1ConcentracionStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(20.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina1ConcentracionMid;
    // ----------- PH ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(9.00, 9999.00, ErrorMessage = "Valor fuera de especificación (mayor o igual a {1})")]
    private decimal? _tina1PhStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(9.00, 9999.00, ErrorMessage = "Valor fuera de especificación (mayor o igual a {1})")]
    private decimal? _tina1PhMid;
    // ----------- Tempreatura ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(50.00, 60.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina1TemperaturaStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _tina1NivelStart;

    // ----------- Presion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(10.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina1PresionStart;
    
    // ----------- Limpieza ----------- 
    [ObservableProperty]
    private bool _tina1LimpiezaStart;

    // ----------------------------- TINTA 2 -----------------------------

    // ----------- Concentracion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(20.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina2ConcentracionStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(20.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina2ConcentracionMid;
    // ----------- PH ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(9.00, 99999.00, ErrorMessage = "Valor fuera de especificación (mayor o igual a {2})")]
    private decimal? _tina2PhStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(9.00, 99999.00, ErrorMessage = "Valor fuera de especificación (mayor o igual a {2})")]
    private decimal? _tina2PhMid;
    // ----------- Tempreatura ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(50.00, 60.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina2TemperaturaStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _tina2NivelStart;

    // ----------- Presion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(10.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina2PresionStart;
    
    // ----------- Limpieza ----------- 
    [ObservableProperty]
    private bool _tina2LimpiezaStart;

    // ----------------------------- TINTA 3 -----------------------------

    // ----------- Concentracion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(20.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina3ConcentracionStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(20.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina3ConcentracionMid;
    // ----------- PH ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(9.00, 9999.00, ErrorMessage = "Valor fuera de especificación (mayor o igual a {1})")]
    private decimal? _tina3PhStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(9.00, 9999.00, ErrorMessage = "Valor fuera de especificación (mayor o igual a {1})")]
    private decimal? _tina3PhMid;
    // ----------- Tempreatura ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(50.00, 60.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina3TemperaturaStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _tina3NivelStart;

    // ----------- Presion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(10.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina3PresionStart;
    
    // ----------- Limpieza ----------- 
    [ObservableProperty]
    private bool _tina3LimpiezaStart;
}