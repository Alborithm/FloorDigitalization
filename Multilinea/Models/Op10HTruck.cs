using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models;

public partial class Op10HTruck : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP 57 IP -----------
    private const double dcp57IpLowerLimit = -.15;
    private const double dcp57IpUpperLimit = .15;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp57IpLowerLimit, dcp57IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp57IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp57IpLowerLimit, dcp57IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp57IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp57IpLowerLimit, dcp57IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp57IpEnd;

    // ----------- DCP 87IP -----------
    [ObservableProperty] private bool _dcp87IpStart;
    [ObservableProperty] private bool _dcp87IpMid;
    [ObservableProperty] private bool _dcp87IpEnd;
    
    // ----------- DCP 119 -----------
    private const double dcp119LowerLimit = -0.10;
    private const double dcp119UpperLimit = 0.10;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp119LowerLimit, dcp119UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp119Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp119LowerLimit, dcp119UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp119Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp119LowerLimit, dcp119UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp119End;

    // ----------- DCP66IP -----------
    private const double dcp66IpLowerLimit = 37.89;
    private const double dcp66IpUpperLimit = 38.69;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp66IpLowerLimit, dcp66IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp66IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp66IpLowerLimit, dcp66IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp66IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp66IpLowerLimit, dcp66IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp66IpEnd;

    // ----------- DCP 95 IP -----------
    private const double dcp95IpLowerLimit = 22.50;
    private const double dcp95IpUpperLimit = 23.00;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp95IpLowerLimit, dcp95IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp95IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp95IpLowerLimit, dcp95IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp95IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp95IpLowerLimit, dcp95IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp95IpEnd;

    // ----------- DCP 96 IP -----------
    private const double dcp96IpLowerLimit = 23.10;
    private const double dcp96IpUpperLimit = 23.60;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp96IpLowerLimit, dcp96IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp96IpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp96IpLowerLimit, dcp96IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp96IpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp96IpLowerLimit, dcp96IpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp96IpEnd;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn", start: true, mid: true, end: false),
            new("Dcp57Ip", start: true, mid: true, end: true),
            new("Dcp87Ip", start: true, mid: true, end: true),
            new("Dcp119", start: true, mid: true, end: true),
            new("Dcp66Ip", start: true, mid: true, end: true),
            new("Dcp95Ip", start: true, mid: true, end: true),
            new("Dcp96Ip", start: true, mid: true, end: true),
        };
    }
}