using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Dk68.Models;

public partial class Op50A : ObservableValidator
{
    // ----------- Concentracion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(7.00, 10.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _prelavadoraAlcalinidadStart;

    // ----------- PH ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(40.00, 55.00, ErrorMessage = "Valor fuera de especificación (mayor o igual a {2})")]
    private decimal? _prelavadoraTemperaturaStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _prelavadoraNivelStart;

    // ----------------------------- TINA 1 -----------------------------

    // ----------- Acidez Total ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(15.00, 17.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina1AcidezTotalStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(15.00, 17.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina1AcidezTotalMid;

    // ----------- Acidez Libre ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.30, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina1AcidezLibreStart;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.30, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina1AcidezLibreMid;

    // ----------- Presion de espreo ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(10.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina1PresionStart;

    // ----------- Tempreatura ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(50.00, 60.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina1TemperaturaStart;

    // ----------- Limpieza ----------- 
    [ObservableProperty]
    private bool _tina1LimpiezaStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _tina1NivelStart;

    // ----------------------------- TINA 2 -----------------------------

    // ----------- Presion de espreo ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(10.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina2PresionStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _tina2NivelStart;

    // ----------------------------- TINA 3 -----------------------------

    // ----------- Concentracion ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(7.00, 9.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina3ConcentracionStart;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(7.00, 9.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina3ConcentracionMid;

    // ----------- PH ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(4.50, 5.50, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina3PhStart;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(4.50, 5.50, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina3PhMid;
    
    // ----------- Presion de espreo ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(10.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina3PresionStart;
    
    // ----------- Limpieza ----------- 
    [ObservableProperty]
    private bool _tina3LimpiezaStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _tina3NivelStart;

    // ----------------------------- TINA 4 -----------------------------

    // ----------- Presion de espreo ----------- 
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(10.00, 30.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _tina4PresionStart;

    // ----------- Nivel ----------- 
    [ObservableProperty]
    private bool _tina4NivelStart;
}