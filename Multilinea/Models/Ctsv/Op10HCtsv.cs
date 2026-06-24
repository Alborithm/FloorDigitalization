using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op10HCtsv : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP 151 (2 readings) -----------
    private const double dcp151LowerLimit = -.2;
    private const double dcp151UpperLimit = .2;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp151LowerLimit, dcp151UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp151_1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp151LowerLimit, dcp151UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp151_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp151LowerLimit, dcp151UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp151_1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp151LowerLimit, dcp151UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp151_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp151LowerLimit, dcp151UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp151_1End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp151LowerLimit, dcp151UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp151_2End;

    // ----------- DCP 22IP -----------
    private const double dcp22IpLowerLimit = -.25;
    private const double dcp22IpUpperLimit = .25;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp22IpLowerLimit, dcp22IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp22IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp22IpLowerLimit, dcp22IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp22IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp22IpLowerLimit, dcp22IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp22IpEnd;

    // ----------- DCP 31IP -----------
    private const double dcp31IpLowerLimit = -.25;
    private const double dcp31IpUpperLimit = .25;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp31IpLowerLimit, dcp31IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp31IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp31IpLowerLimit, dcp31IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp31IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp31IpLowerLimit, dcp31IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp31IpEnd;

    // ----------- DCP40IP_1 -----------
    [ObservableProperty] private bool _dcp40Ip_1Start;
    [ObservableProperty] private bool _dcp40Ip_1Mid;
    [ObservableProperty] private bool _dcp40Ip_1End;

    // ----------- DCP40IP_2 -----------
    private const double dcp40Ip_2LowerLimit = 35.95;
    private const double dcp40Ip_2UpperLimit = 36.25;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40Ip_2LowerLimit, dcp40Ip_2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp40Ip_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40Ip_2LowerLimit, dcp40Ip_2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40Ip_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40Ip_2LowerLimit, dcp40Ip_2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40Ip_2End;

    // ----------- DCP 42IP -----------
    private const double dcp42IpLowerLimit = -.20;
    private const double dcp42IpUpperLimit = .20;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42IpLowerLimit, dcp42IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp42IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42IpLowerLimit, dcp42IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp42IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42IpLowerLimit, dcp42IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp42IpEnd;

    // ----------- DCP SN4 -----------
    private const double dcpSn4LowerLimit = -.25;
    private const double dcpSn4UpperLimit = .25;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn4LowerLimit, dcpSn4UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn4Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn4LowerLimit, dcpSn4UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn4Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn4LowerLimit, dcpSn4UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn4End;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn", start: true, mid: true, end: false),
            new("Dcp151_1", start: true, mid: true, end: true),
            new("Dcp151_2", start: true, mid: true, end: true),
            new("Dcp22Ip", start: true, mid: true, end: true),
            new("Dcp31Ip", start: true, mid: true, end: true),
            new("Dcp40Ip_1", start: true, mid: true, end: true),
            new("Dcp40Ip_2", start: true, mid: true, end: true),
            new("Dcp42Ip", start: true, mid: true, end: true),
            new("DcpSn4", start: true, mid: true, end: true),
        };
    }
}