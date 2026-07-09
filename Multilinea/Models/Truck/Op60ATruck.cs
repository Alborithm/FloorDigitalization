using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Truck;

public partial class Op60ATruck : ObservableValidator
{
    // ----------- DCP 89 -----------
    [ObservableProperty] private bool _dcp89Start;
    [ObservableProperty] private bool _dcp89Mid;
    [ObservableProperty] private bool _dcp89End;

    // ----------- DCP 99 -----------
    private const double dcp99LowerLimit = .25;
    private const double dcp99UpperLimit = .6;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp99LowerLimit, dcp99UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp99_1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp99LowerLimit, dcp99UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp99_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp99LowerLimit, dcp99UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp99_1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp99LowerLimit, dcp99UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp99_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp99LowerLimit, dcp99UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp99_1End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp99LowerLimit, dcp99UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp99_2End;

    // ----------- DCP 113 -----------
    [ObservableProperty] private bool _dcp113Start;
    [ObservableProperty] private bool _dcp113Mid;
    [ObservableProperty] private bool _dcp113End;

    // ----------- DCP 23 -----------
    [ObservableProperty] private bool _dcp23Start;
    [ObservableProperty] private bool _dcp23Mid;
    [ObservableProperty] private bool _dcp23End;

    // ----------- DCP 34 62 -----------
    [ObservableProperty] private bool _dcp34_62Start;
    [ObservableProperty] private bool _dcp34_62Mid;
    [ObservableProperty] private bool _dcp34_62End;
    
    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("Dcp89", start: true, mid: true, end: true),
            new("Dcp99_1", start: true, mid: true, end: true),
            new("Dcp99_2", start: true, mid: true, end: true),
            new("Dcp113", start: true, mid: true, end: true),
            new("Dcp23", start: true, mid: true, end: true),
            new("Dcp34_62", start: true, mid: true, end: true),
        };
    }
}