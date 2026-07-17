using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.NewPenta.Models;

// Op 10w and 20 w
public partial class Anillos : ObservableValidator
{
    // ----------- DCP SN (01) -----------
    [ObservableProperty] private bool _dcpSn01Start;

    // ----------- DCP 20 -----------
    private const double dcp20LowerLimit = -.25;
    private const double dcp20UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp20LowerLimit, dcp20UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp20Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp20LowerLimit, dcp20UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp20Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp20LowerLimit, dcp20UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp20End;
    
    // ----------- DCP 24 -----------
    private const double dcp24LowerLimit = -.10;
    private const double dcp24UpperLimit = .10;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp24LowerLimit, dcp24UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp24Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp24LowerLimit, dcp24UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp24Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp24LowerLimit, dcp24UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp24End;

    // ----------- DCP 25 -----------
    [ObservableProperty] private bool _dcp25Start;
    [ObservableProperty] private bool _dcp25Mid;
    [ObservableProperty] private bool _dcp25End;
    
    // ----------- DCP 31 -----------
    private const double dcp31LowerLimit = -.6;
    private const double dcp31UpperLimit = .6;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp31LowerLimit, dcp31UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp31Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp31LowerLimit, dcp31UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp31Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp31LowerLimit, dcp31UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp31End;

    // ----------- DCP 32 -----------
    private const double dcp32LowerLimit = -.15;
    private const double dcp32UpperLimit = .15;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp32LowerLimit, dcp32UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp32Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp32LowerLimit, dcp32UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp32Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp32LowerLimit, dcp32UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp32End;

    // ----------- DCP 20 -----------
    private const double dcp21LowerLimit = -.065;
    private const double dcp21UpperLimit = .065;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp21LowerLimit, dcp21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp21_1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp21LowerLimit, dcp21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp21_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp21LowerLimit, dcp21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp21_1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp21LowerLimit, dcp21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp21_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp21LowerLimit, dcp21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp21_1End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp21LowerLimit, dcp21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp21_2End;

    // ----------- DCP 26 -----------

    [ObservableProperty] private bool _dcp26Start;
    [ObservableProperty] private bool _dcp26Mid;
    [ObservableProperty] private bool _dcp26End;
    // private const double dcp26LowerLimit = 0.0;
    // private const double dcp26UpperLimit = .1;

    // [ObservableProperty][NotifyDataErrorInfo]
    // [Range(dcp26LowerLimit, dcp26UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    // private decimal? _dcp26Start;
    // [ObservableProperty][NotifyDataErrorInfo]
    // [Range(dcp26LowerLimit, dcp26UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    // private decimal? _dcp26Mid;
    // [ObservableProperty][NotifyDataErrorInfo]
    // [Range(dcp26LowerLimit, dcp26UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    // private decimal? _dcp26End;

    // ----------- DCP SN (2) -----------
    private const double dcpSn02LowerLimit = 0.0;
    private const double dcpSn02UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn02LowerLimit, dcpSn02UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn02Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn02LowerLimit, dcpSn02UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn02Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn02LowerLimit, dcpSn02UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn02End;

    // ----------- DCP 29 -----------
    private const double dcp29LowerLimit = -0.25;
    private const double dcp29UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp29LowerLimit, dcp29UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp29Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp29LowerLimit, dcp29UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp29Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp29LowerLimit, dcp29UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp29End;

    // ----------- DCP 30 -----------

    [ObservableProperty] private bool _dcp30Start;
    [ObservableProperty] private bool _dcp30Mid;
    [ObservableProperty] private bool _dcp30End;


    // ----------- DCP 22 -----------
    private const double dcp22LowerLimit = 5.0;
    private const double dcp22UpperLimit = 7.0;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp22LowerLimit, dcp22UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp22Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp22LowerLimit, dcp22UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp22Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp22LowerLimit, dcp22UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp22End;

    // ----------- DCP 121 85 -----------

    [ObservableProperty] private bool _dcp121_85Start;
    [ObservableProperty] private bool _dcp121_85Mid;
    [ObservableProperty] private bool _dcp121_85End;




    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn01", start: true, mid: false, end: false),
            new("Dcp20", start: true, mid: true, end: true),
            new("Dcp24", start: true, mid: true, end: true),
            new("Dcp25", start: true, mid: true, end: true),
            new("Dcp31", start: true, mid: true, end: true),
            new("Dcp32", start: true, mid: true, end: true),
            new("Dcp20_1", start: true, mid: true, end: true),
            new("Dcp20_2", start: true, mid: true, end: true),
            new("Dcp26", start: true, mid: true, end: true),
            new("DcpSn02", start: true, mid: true, end: true),
            new("Dcp29", start: true, mid: true, end: true),
            new("Dcp30", start: true, mid: true, end: true),
            new("Dcp22", start: true, mid: true, end: true),
            new("Dcp121_85", start: true, mid: true, end: true),
        };
    }
}