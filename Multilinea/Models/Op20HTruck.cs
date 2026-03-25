using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models;

public partial class Op20HTruck : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP SN 85 -----------
    private const double dcpSn85LowerLimit = 0.00;
    private const double dcpSn85UpperLimit = 3000.00;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn85LowerLimit, dcpSn85UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn85Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn85LowerLimit, dcpSn85UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn85Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn85LowerLimit, dcpSn85UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn85End;

    // ----------- DCP 48 IP -----------
    
    private const double dcp48IpLowerLimit = -0.25;
    private const double dcp48IpUpperLimit = 0.25;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp48IpLowerLimit, dcp48IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? dcp48IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp48IpLowerLimit, dcp48IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? dcp48IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp48IpLowerLimit, dcp48IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? dcp48IpEnd;

    // ----------- DCP74 -----------
    private const double dcp74LowerLimit = -0.30;
    private const double dcp74UpperLimit = 0.30;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp74LowerLimit, dcp74UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp74Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp74LowerLimit, dcp74UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp74Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp74LowerLimit, dcp74UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp74End;

    // ----------- DCP76 -----------
    private const double dcp76LowerLimit = -0.25;
    private const double dcp76UpperLimit = 0.25;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp76LowerLimit, dcp76UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp76Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp76LowerLimit, dcp76UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp76Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp76LowerLimit, dcp76UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp76End;

    // ----------- DCP SN5 -----------
    private const double dcpSn5LowerLimit = -0.1;
    private const double dcpSn5UpperLimit = 0.1;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn5LowerLimit, dcpSn5UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn5Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn5LowerLimit, dcpSn5UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn5Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn5LowerLimit, dcpSn5UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn5End;

    // ----------- DCP Sn 21 -----------
    private const double dcpSn21LowerLimit = -.25;
    private const double dcpSn21UpperLimit = .25;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn21LowerLimit, dcpSn21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn21Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn21LowerLimit, dcpSn21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn21Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn21LowerLimit, dcpSn21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn21End;

    // ----------- DCP Sn 78 -----------
    [ObservableProperty] private bool _dcpSn78Start;
    [ObservableProperty] private bool _dcpSn78Mid;
    [ObservableProperty] private bool _dcpSn78End;

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
            new("DcpSn85", start: true, mid: true, end: true),
            new("Dcp48Ip", start: true, mid: true, end: true),
            new("Dcp74", start: true, mid: true, end: true),
            new("Dcp76", start: true, mid: true, end: true),
            new("DcpSn5", start: true, mid: true, end: true),
            new("DcpSn21", start: true, mid: true, end: true),
            new("DcpSn78", start: true, mid: true, end: true),
            new("Dcp23", start: true, mid: true, end: true),
            new("Dcp34", start: true, mid: true, end: true),
        };
    }
}