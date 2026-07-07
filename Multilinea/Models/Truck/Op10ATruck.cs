using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Truck;

public partial class Op30ATruck : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP SN 80 -----------
    private const double dcpSn80LowerLimit = .90;
    private const double dcpSn80UpperLimit = 1.5;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn80LowerLimit, dcpSn80UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn80Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn80LowerLimit, dcpSn80UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn80Mid;

    // ----------- DCP 49 -----------
    private const double dcp49LowerLimit = -.100;
    private const double dcp49UpperLimit = .100;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp49LowerLimit, dcp49UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp49Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp49LowerLimit, dcp49UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp49Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp49LowerLimit, dcp49UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp49End;

    // ----------- DCP 50 -----------
    private const double dcp50LowerLimit = 0.0;
    private const double dcp50UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp50LowerLimit, dcp50UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp50Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp50LowerLimit, dcp50UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp50Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp50LowerLimit, dcp50UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp50End;

    // ----------- DCP 51 -----------
    private const double dcp51LowerLimit = -.25;
    private const double dcp51UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp51LowerLimit, dcp51UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp51Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp51LowerLimit, dcp51UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp51Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp51LowerLimit, dcp51UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp51End;

    // ----------- DCP 52 -----------
    private const double dcp52LowerLimit = 0.0;
    private const double dcp52UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp52LowerLimit, dcp52UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp52Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp52LowerLimit, dcp52UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp52Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp52LowerLimit, dcp52UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp52End;
    
    // ----------- DCP 58 -----------
    private const double dcp58LowerLimit = 0.0;
    private const double dcp58UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp58LowerLimit, dcp58UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp58Start;









    // ----------- DCP 23 -----------
    [ObservableProperty] private bool _dcp23Start;
    [ObservableProperty] private bool _dcp23Mid;
    [ObservableProperty] private bool _dcp23End;

    // ----------- DCP 34 -----------
    [ObservableProperty] private bool _dcp34Start;
    [ObservableProperty] private bool _dcp34Mid;
    [ObservableProperty] private bool _dcp34End;
    
    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("Dcp22", start: true, mid: true, end: true),
            new("DcpSn33", start: true, mid: true, end: true),
            new("Dcp23", start: true, mid: true, end: true),
            new("Dcp34", start: true, mid: true, end: true),
        };
    }
}