using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Duramax.Models;

public partial class Op10W20W : ObservableValidator
{
    private const double dcp1Ip1LowerLimit = -.15;
    private const double dcp1Ip1UpperLimit = .15;
    private const double dcp1Ip2LowerLimit = -.15;
    private const double dcp1Ip2UpperLimit = .15;
    private const double dcp6LowerLimit = -.25;
    private const double dcp6UpperLimit = .25;
    private const double dcp7LowerLimit = -.4;
    private const double dcp7UpperLimit = .4;
    private const double dcp94LowerLimit = 0.0;
    private const double dcp94UpperLimit = .6;
    private const double dcp101LowerLimit = -.20;
    private const double dcp101UpperLimit = .20;
    private const double dcp102IpLowerLimit = 0.0;
    private const double dcp102IpUpperLimit = 0.10;

    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;

    // ----------- DCP 1 IP (1) -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp1Ip1LowerLimit, dcp1Ip1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp1Ip1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp1Ip1LowerLimit, dcp1Ip1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1Ip1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp1Ip1LowerLimit, dcp1Ip1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1Ip1End;

    // ----------- DCP 1 IP (2) -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp1Ip2LowerLimit, dcp1Ip2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp1Ip2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp1Ip2LowerLimit, dcp1Ip2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1Ip2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp1Ip2LowerLimit, dcp1Ip2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1Ip2End;
    
    // ----------- DCP 6 -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp6LowerLimit, dcp6UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp6_1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp6LowerLimit, dcp6UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp6_1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp6LowerLimit, dcp6UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp6_1End;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp6LowerLimit, dcp6UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp6_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp6LowerLimit, dcp6UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp6_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp6LowerLimit, dcp6UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp6_2End;

    // ----------- DCP 7 -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp7LowerLimit, dcp7UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp7Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp7LowerLimit, dcp7UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp7Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp7LowerLimit, dcp7UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp7End;

    // ----------- DCP 94 -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp94LowerLimit, dcp94UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp94Start;

    // ----------- DCP 101 -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp101LowerLimit, dcp101UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp101Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp101LowerLimit, dcp101UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp101Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp101LowerLimit, dcp101UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp101End;

    // ----------- DCP 102Ip -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp102IpLowerLimit, dcp102IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp102IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp102IpLowerLimit, dcp102IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp102IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp102IpLowerLimit, dcp102IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp102IpEnd;

    // ----------- DCP 60 -----------
    [ObservableProperty]
    private bool _dcp60Start;
    [ObservableProperty]
    private bool _dcp60Mid;
    [ObservableProperty]
    private bool _dcp60End;


    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn",true, false, false),
            new("Dcp1Ip1", start: true, mid: true, end: true),
            new("Dcp1Ip2", start: true, mid: true, end: true),
            new("Dcp6_1", start: true, mid: true, end: true),
            new("Dcp6_2", start: true, mid: true, end: true),
            new("Dcp7", start: true, mid: true, end: true),
            new("Dcp94", start: true, mid: false, end: false),
            new("Dcp101", start: true, mid: true, end: true),
            new("Dcp102Ip", start: true, mid: true, end: true),
            new("Dcp60", start: true, mid: true, end: true),
        };
    }
}