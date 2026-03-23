using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Duramax.Models;

public partial class Op30WCara2 : ObservableValidator
{
    private const double dcp1LowerLimit = -.25;
    private const double dcp1UpperLimit = .25;
    private const double dcp2LowerLimit = -.5;
    private const double dcp2UpperLimit = .5;
    private const double dcp3LowerLimit = 0.0;
    private const double dcp3UpperLimit = .10;
    private const double dcp13BIpLowerLimit = 154.665;
    private const double dcp13BIpUpperLimit = 154.865;
    private const double dcp42BLowerLimit = 0.0;
    private const double dcp42BUpperLimit = .25;
    private const double dcp43BLowerLimit = 0.0;
    private const double dcp43BUpperLimit = .25;

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

    // ----------- DCP 3 x 3 -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp3LowerLimit, dcp3UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp3_1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp3LowerLimit, dcp3UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp3_1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp3LowerLimit, dcp3UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp3_1End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp3LowerLimit, dcp3UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp3_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp3LowerLimit, dcp3UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp3_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp3LowerLimit, dcp3UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp3_2End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp3LowerLimit, dcp3UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp3_3Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp3LowerLimit, dcp3UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp3_3Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp3LowerLimit, dcp3UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp3_3End;
    
    // ----------- DCP 13 B IP -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp13BIpLowerLimit, dcp13BIpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp13BIpStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp13BIpLowerLimit, dcp13BIpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp13BIpMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp13BIpLowerLimit, dcp13BIpUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp13BIpEnd;

    // ----------- DCP 30 -----------
    [ObservableProperty]
    private bool _dcp30Start;
    [ObservableProperty]
    private bool _dcp30Mid;
    [ObservableProperty]
    private bool _dcp30End;

    // ----------- DCP 42B -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42BLowerLimit, dcp42BUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp42BStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42BLowerLimit, dcp42BUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp42BMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42BLowerLimit, dcp42BUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp42BEnd;

    // ----------- DCP 43B -----------
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp43BLowerLimit, dcp43BUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp43BStart;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp43BLowerLimit, dcp43BUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp43BMid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp43BLowerLimit, dcp43BUpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp43BEnd;

    // ----------- DCP 79 -----------
    [ObservableProperty]
    private bool _dcp79Start;
    [ObservableProperty]
    private bool _dcp79Mid;
    [ObservableProperty]
    private bool _dcp79End;

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
            new("Dcp3", start: true, mid: true, end: true),
            new("Dcp13BIp", start: true, mid: true, end: true),
            new("Dcp30", start: true, mid: true, end: true),
            new("Dcp42B", start: true, mid: true, end: true),
            new("Dcp43B", start: true, mid: true, end: true),
            new("Dcp79", start: true, mid: true, end: true),
            new("Dcp26", start: true, mid: true, end: true),
            new("Dcp74_80", start: true, mid: true, end: true),
        };
    }
}