using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.GenVMega.Models;

public partial class Prelavadora : ObservableValidator
{
    // ----------- Alalinidad -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(7.00, 10.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _alcalinidadStart;

    // ----------- Temperatura -----------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(40.00, 55.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _temperaturaStart;
    
    // ----------- Nivel -----------
    [ObservableProperty]
    private bool _nivelStart;
}