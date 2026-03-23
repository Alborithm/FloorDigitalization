using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Duramax.Models;

public partial class Balanceo40W : ObservableValidator
{
    private const double dcp75LowerLimit = 0.0;
    private const double dcp75UpperLimit = 10.0;

    // ----------- DCP 16 -----------
    [ObservableProperty] private bool _dcp16Start;
    [ObservableProperty] private bool _dcp16Mid;
    [ObservableProperty] private bool _dcp16End;

    // ----------- DCP 17 -----------
    [ObservableProperty] private bool _dcp17Start;
    [ObservableProperty] private bool _dcp17Mid;
    [ObservableProperty] private bool _dcp17End;

    // ----------- DCP 18 -----------
    [ObservableProperty] private bool _dcp18Start;
    [ObservableProperty] private bool _dcp18Mid;
    [ObservableProperty] private bool _dcp18End;

    // ----------- DCP 19 -----------
    [ObservableProperty] private bool _dcp19Start;
    [ObservableProperty] private bool _dcp19Mid;
    [ObservableProperty] private bool _dcp19End;

    // ----------- DCP 75 -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp75LowerLimit, dcp75UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp75Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp75LowerLimit, dcp75UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp75Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp75LowerLimit, dcp75UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp75End;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("Dcp16", start: true, mid: true, end: true),
            new("Dcp17", start: true, mid: true, end: true),
            new("Dcp18", start: true, mid: true, end: true),
            new("Dcp19", start: true, mid: true, end: true),
            new("Dcp75", start: true, mid: true, end: true),
        };
    }
}