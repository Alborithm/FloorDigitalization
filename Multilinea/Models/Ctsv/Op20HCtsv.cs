using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op20HCtsv : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP SN 25 -----------
    private const double dcpSn25LowerLimit = 0.00;
    private const double dcpSn25UpperLimit = 2500.00;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn25LowerLimit, dcpSn25UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn25Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn25LowerLimit, dcpSn25UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn25Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn25LowerLimit, dcpSn25UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn25End;

    // ----------- DCP 11 IP -----------
    
    private const double dcp11IpLowerLimit = -0.25;
    private const double dcp11IpUpperLimit = 0.25;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp11IpLowerLimit, dcp11IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? dcp11IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp11IpLowerLimit, dcp11IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? dcp11IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp11IpLowerLimit, dcp11IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? dcp11IpEnd;

    // ----------- DCP12Ip -----------
    private const double dcp12IpLowerLimit = -0.10;
    private const double dcp12IpUpperLimit = 0.10;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp12IpLowerLimit, dcp12IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp12IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp12IpLowerLimit, dcp12IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp12IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp12IpLowerLimit, dcp12IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp12IpEnd;

    // ----------- DCP25 -----------
    private const double dcp25LowerLimit = -0.3;
    private const double dcp25UpperLimit = 0.3;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp25LowerLimit, dcp25UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp25Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp25LowerLimit, dcp25UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp25Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp25LowerLimit, dcp25UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp25End;

    // ----------- DCP 26 -----------
    private const double dcp26LowerLimit = -0.25;
    private const double dcp26UpperLimit = 0.25;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp26LowerLimit, dcp26UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp26Start;

    // ----------- DCP 79 156 -----------
    [ObservableProperty] private bool _dcp79_156Start;
    [ObservableProperty] private bool _dcp79_156Mid;
    [ObservableProperty] private bool _dcp79_156End;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn", start: true, mid: true, end: false),
            new("DcpSn25", start: true, mid: true, end: true),
            new("Dcp11Ip", start: true, mid: true, end: true),
            new("Dcp12Ip", start: true, mid: true, end: true),
            new("Dcp25", start: true, mid: true, end: true),
            new("Dcp26", start: true, mid: false, end: false),
            new("Dcp79_156", start: true, mid: true, end: true),
        };
    }
}