using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op60ACtsv : ObservableValidator
{
    // ----------- DCP 52 -----------
    [ObservableProperty] private bool _dcp52Start;

    // ----------- DCP 73 -----------
    private const double dcp73LowerLimit = 0;
    private const double dcp73UpperLimit = 180;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp73LowerLimit, dcp73UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp73Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp73LowerLimit, dcp73UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp73Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp73LowerLimit, dcp73UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp73End;

    // ----------- DCP 55 -----------
    [ObservableProperty] private bool _dcp55Start;
    [ObservableProperty] private bool _dcp55Mid;
    [ObservableProperty] private bool _dcp55End;

    // ----------- DCP 54 -----------
    [ObservableProperty] private bool _dcp54Start;
    [ObservableProperty] private bool _dcp54Mid;
    [ObservableProperty] private bool _dcp54End;

    // ----------- DCP 53 -----------
    [ObservableProperty] private bool _dcp53Start;
    [ObservableProperty] private bool _dcp53Mid;
    [ObservableProperty] private bool _dcp53End;

    // ----------- DCP 79 156 -----------
    [ObservableProperty] private bool _dcp79_156Start;
    [ObservableProperty] private bool _dcp79_156Mid;
    [ObservableProperty] private bool _dcp79_156End;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("Dcp52", start: true, mid: false, end: false),
            new("Dcp73", start: true, mid: true, end: true),
            new("Dcp55", start: true, mid: true, end: true),
            new("Dcp54", start: true, mid: true, end: true),
            new("Dcp53", start: true, mid: true, end: true),
            new("Dcp79_156", start: true, mid: true, end: true),
        };
    }
}