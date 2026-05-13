using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models;

public partial class Op20WTruck : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP 131 IP -----------
    private const double dcp131IpLowerLimit = -.25;
    private const double dcp131IpUpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp131IpLowerLimit, dcp131IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp131IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp131IpLowerLimit, dcp131IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp131IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp131IpLowerLimit, dcp131IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp131IpEnd;

    // ----------- DCP 135 -----------
    private const double dcp135LowerLimit = -.15;
    private const double dcp135UpperLimit = .15;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp135LowerLimit, dcp135UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp135Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp135LowerLimit, dcp135UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp135Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp135LowerLimit, dcp135UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp135End;

    // ----------- DCP 139 -----------
    private const double dcp139LowerLimit = 4.0;
    private const double dcp139UpperLimit = 6.5;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp139LowerLimit, dcp139UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp139Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp139LowerLimit, dcp139UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp139Mid;

    // ----------- DCP 142 -----------
    private const double dcp142LowerLimit = 4.0;
    private const double dcp142UpperLimit = 6.5;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp142LowerLimit, dcp142UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp142Start;

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
            new("DcpSn", start: true, mid: true, end: false),
            new("Dcp131Ip", start: true, mid: true, end: true),
            new("Dcp135", start: true, mid: true, end: true),
            new("Dcp139", start: true, mid: true, end: false),
            new("Dcp142", start: true, mid: false, end: false),
            new("Dcp23", start: true, mid: true, end: true),
            new("Dcp34", start: true, mid: true, end: true),
        };
    }
}