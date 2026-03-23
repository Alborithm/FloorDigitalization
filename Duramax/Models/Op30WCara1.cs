using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Duramax.Models;

public partial class Op30WCara1 : ObservableValidator
{
    private const double dcp1LowerLimit = -.25;
    private const double dcp1UpperLimit = .25;
    private const double dcp2LowerLimit = -.5;
    private const double dcp2UpperLimit = .5;
    private const double dcp13BIpLowerLimit = 154.665;
    private const double dcp13BIpUpperLimit = 154.865;
    private const double dcp42ALowerLimit = 0.0;
    private const double dcp42AUpperLimit = .25;
    private const double dcp43ALowerLimit = 0.0;
    private const double dcp43AUpperLimit = .25;
    private const double dcp78LowerLimit = 0.0;
    private const double dcp78UpperLimit = .10;

    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;

    // ----------- DCP 1 -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp1LowerLimit, dcp1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp1LowerLimit, dcp1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp1LowerLimit, dcp1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1End;

    // ----------- DCP 2 x 3-----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp2LowerLimit, dcp2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp2_1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp2LowerLimit, dcp2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp2_1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp2LowerLimit, dcp2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp2_1End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp2LowerLimit, dcp2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp2_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp2LowerLimit, dcp2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp2_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp2LowerLimit, dcp2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp2_2End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp2LowerLimit, dcp2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp2_3Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp2LowerLimit, dcp2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp2_3Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp2LowerLimit, dcp2UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp2_3End;
    
    // ----------- DCP 13 B IP  -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp13BIpLowerLimit, dcp13BIpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp13BIpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp13BIpLowerLimit, dcp13BIpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp13BIpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp13BIpLowerLimit, dcp13BIpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp13BIpEnd;

    // ----------- DCP 21 -----------
    [ObservableProperty]
    private bool _dcp21Start;
    [ObservableProperty]
    private bool _dcp21Mid;
    [ObservableProperty]
    private bool _dcp21End;

    // ----------- DCP 22 -----------
    [ObservableProperty]
    private bool _dcp22Start;
    [ObservableProperty]
    private bool _dcp22Mid;
    [ObservableProperty]
    private bool _dcp22End;

    // ----------- DCP 31 -----------
    [ObservableProperty]
    private bool _dcp31Start;
    [ObservableProperty]
    private bool _dcp31Mid;
    [ObservableProperty]
    private bool _dcp31End;

    // ----------- DCP 42A -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42ALowerLimit, dcp42AUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp42AStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42ALowerLimit, dcp42AUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp42AMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42ALowerLimit, dcp42AUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp42AEnd;

    // ----------- DCP 43A -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp43ALowerLimit, dcp43AUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp43AStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp43ALowerLimit, dcp43AUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp43AMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp43ALowerLimit, dcp43AUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp43AEnd;

    // ----------- DCP 78 x 3 -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp78LowerLimit, dcp78UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp78_1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp78LowerLimit, dcp78UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp78_1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp78LowerLimit, dcp78UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp78_1End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp78LowerLimit, dcp78UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp78_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp78LowerLimit, dcp78UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp78_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp78LowerLimit, dcp78UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp78_2End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp78LowerLimit, dcp78UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp78_3Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp78LowerLimit, dcp78UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp78_3Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp78LowerLimit, dcp78UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp78_3End;

    // ----------- DCP 23 -----------
    [ObservableProperty]
    private bool _dcp23Start;
    [ObservableProperty]
    private bool _dcp23Mid;
    [ObservableProperty]
    private bool _dcp23End;

    // ----------- DCP 26 -----------
    [ObservableProperty]
    private bool _dcp26Start;
    [ObservableProperty]
    private bool _dcp26Mid;
    [ObservableProperty]
    private bool _dcp26End;

    // ----------- DCP 74 80 -----------
    [ObservableProperty]
    private bool _dcp74_80Start;
    [ObservableProperty]
    private bool _dcp74_80Mid;
    [ObservableProperty]
    private bool _dcp74_80End;


    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn", start: true, mid: false, end: false),
            new("Dcp1", start: true, mid: true, end: true),
            new("Dcp2_1", start: true, mid: true, end: true),
            new("Dcp2_2", start: true, mid: true, end: true),
            new("Dcp2_3", start: true, mid: true, end: true),
            new("Dcp13BIp", start: true, mid: true, end: true),
            new("Dcp21", start: true, mid: true, end: true),
            new("Dcp22", start: true, mid: true, end: true),
            new("Dcp31", start: true, mid: true, end: true),
            new("Dcp42A", start: true, mid: true, end: true),
            new("Dcp43A", start: true, mid: true, end: true),
            new("Dcp78_1", start: true, mid: true, end: true),
            new("Dcp78_2", start: true, mid: true, end: true),
            new("Dcp78_3", start: true, mid: true, end: true),
            new("Dcp23", start: true, mid: true, end: true),
            new("Dcp26", start: true, mid: true, end: true),
            new("Dcp74_80", start: true, mid: true, end: true),
        };
    }
}