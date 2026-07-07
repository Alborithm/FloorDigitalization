using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op40ACtsv : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP 12 -----------
    private const double dcp12LowerLimit = -.10;
    private const double dcp12UpperLimit = .10;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp12LowerLimit, dcp12UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp12Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp12LowerLimit, dcp12UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp12Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp12LowerLimit, dcp12UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp12End;

    // ----------- DCP 13 -----------
    private const double dcp13LowerLimit = 0.0;
    private const double dcp13UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp13LowerLimit, dcp13UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp13Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp13LowerLimit, dcp13UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp13Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp13LowerLimit, dcp13UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp13End;


    // ----------- DCP 14 -----------
    private const double dcp14LowerLimit = -0.25;
    private const double dcp14UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp14LowerLimit, dcp14UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp14Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp14LowerLimit, dcp14UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp14Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp14LowerLimit, dcp14UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp14End;

    // ----------- DCP 15 -----------
    private const double dcp15LowerLimit = -0.25;
    private const double dcp15UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp15LowerLimit, dcp15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp15Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp15LowerLimit, dcp15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp15Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp15LowerLimit, dcp15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp15End;

    // ----------- DCP 16 -----------
    private const double dcp16LowerLimit = 0.0;
    private const double dcp16UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp16LowerLimit, dcp16UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp16Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp16LowerLimit, dcp16UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp16Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp16LowerLimit, dcp16UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp16End;

    // ----------- DCP 17 -----------
    private const double dcp17LowerLimit = 0.0;
    private const double dcp17UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp17LowerLimit, dcp17UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp17Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp17LowerLimit, dcp17UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp17Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp17LowerLimit, dcp17UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp17End;

    // ----------- DCP 18 -----------
    private const double dcp18LowerLimit = -0.25;
    private const double dcp18UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp18LowerLimit, dcp18UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp18Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp18LowerLimit, dcp18UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp18Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp18LowerLimit, dcp18UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp18End;

    // ----------- DCP 20 -----------
    private const double dcp20LowerLimit = -0.30;
    private const double dcp20UpperLimit = 0.30;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp20LowerLimit, dcp20UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp20Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp20LowerLimit, dcp20UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp20Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp20LowerLimit, dcp20UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp20End;

    // ----------- DCP 21 -----------
    private const double dcp21LowerLimit = -0.0;
    private const double dcp21UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp21LowerLimit, dcp21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp21Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp21LowerLimit, dcp21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp21Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp21LowerLimit, dcp21UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp21End;

    // ----------- DCP 24 -----------
    [ObservableProperty] private bool _dcp24Start;
    [ObservableProperty] private bool _dcp24Mid;
    [ObservableProperty] private bool _dcp24End;

    // ----------- DCP 23 -----------
    [ObservableProperty] private bool _dcp23Start;
    [ObservableProperty] private bool _dcp23Mid;
    [ObservableProperty] private bool _dcp23End;

    // ----------- DCP 27 -----------
    private const double dcp27LowerLimit = 0.00;
    private const double dcp27UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp27LowerLimit, dcp27UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp27Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp27LowerLimit, dcp27UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp27Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp27LowerLimit, dcp27UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp27End;

    // ----------- DCP 29 -----------
    private const double dcp29LowerLimit = 0.00;
    private const double dcp29UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp29LowerLimit, dcp29UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp29Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp29LowerLimit, dcp29UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp29Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp29LowerLimit, dcp29UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp29End;
    
    // ----------- DCP 31 -----------
    private const double dcp31LowerLimit = -0.25;
    private const double dcp31UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp31LowerLimit, dcp31UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp31Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp31LowerLimit, dcp31UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp31Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp31LowerLimit, dcp31UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp31End;

    // ----------- DCP 30 -----------
    private const double dcp30LowerLimit = 0.0;
    private const double dcp30UpperLimit = 0.125;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp30LowerLimit, dcp30UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp30Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp30LowerLimit, dcp30UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp30Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp30LowerLimit, dcp30UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp30End;

    // ----------- DCP 40 -----------
    [ObservableProperty] private bool _dcp40_1Start;
    [ObservableProperty] private bool _dcp40_1Mid;
    [ObservableProperty] private bool _dcp40_1End;

    // ----------- DCP 40 (3 records) -----------
    private const double dcp40LowerLimit = 37.600;
    private const double dcp40UpperLimit = 37.625;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40LowerLimit, dcp40UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40_2_1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40LowerLimit, dcp40UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40_2_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40LowerLimit, dcp40UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40_2_3Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40LowerLimit, dcp40UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40_2_1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40LowerLimit, dcp40UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40_2_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40LowerLimit, dcp40UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40_2_3Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40LowerLimit, dcp40UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40_2_1End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40LowerLimit, dcp40UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40_2_2End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp40LowerLimit, dcp40UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp40_2_3End;

    // ----------- DCP 41 -----------
    private const double dcp41LowerLimit = 1.25;
    private const double dcp41UpperLimit = 2.5;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp41LowerLimit, dcp41UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp41Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp41LowerLimit, dcp41UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp41Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp41LowerLimit, dcp41UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp41End;

    // ----------- DCP 42 -----------
    private const double dcp42LowerLimit = -.25;
    private const double dcp42UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42LowerLimit, dcp42UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp42Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42LowerLimit, dcp42UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp42Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp42LowerLimit, dcp42UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp42End;

    // ----------- DCP 43 -----------
    private const double dcp43LowerLimit = -.25;
    private const double dcp43UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp43LowerLimit, dcp43UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp43Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp43LowerLimit, dcp43UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp43Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp43LowerLimit, dcp43UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp43End;

    // ----------- DCP 45 -----------
    [ObservableProperty] private bool _dcp45Start;
    [ObservableProperty] private bool _dcp45Mid;
    [ObservableProperty] private bool _dcp45End;

    // ----------- DCP 46 -----------
    private const double dcp46LowerLimit = -.065;
    private const double dcp46UpperLimit = .065;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp46LowerLimit, dcp46UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp46Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp46LowerLimit, dcp46UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp46Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp46LowerLimit, dcp46UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp46End;

    // ----------- DCP 47 -----------
    private const double dcp47LowerLimit = 0.00;
    private const double dcp47UpperLimit = 0.025;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp47LowerLimit, dcp47UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp47Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp47LowerLimit, dcp47UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp47Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp47LowerLimit, dcp47UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp47End;

    // ----------- DCP 155 -----------
    private const double dcp155LowerLimit = 0.00;
    private const double dcp155UpperLimit = 0.05;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp155LowerLimit, dcp155UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp155Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp155LowerLimit, dcp155UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp155Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp155LowerLimit, dcp155UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp155End;

    // ----------- DCP 79 156 -----------
    [ObservableProperty] private bool _dcp79_156Start;
    [ObservableProperty] private bool _dcp79_156Mid;
    [ObservableProperty] private bool _dcp79_156End;

    // ----------- DCP SN 1 -----------
    [ObservableProperty] private bool _dcpSn1Start;
    [ObservableProperty] private bool _dcpSn1Mid;
    [ObservableProperty] private bool _dcpSn1End;

    // ----------- DCP SN 2 -----------
    [ObservableProperty] private bool _dcpSn2Start;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn", start: true, mid: true, end: false),
            new("Dcp12", start: true, mid: true, end: true),
            new("Dcp13", start: true, mid: true, end: true),
            new("Dcp14", start: true, mid: true, end: true),
            new("Dcp15", start: true, mid: true, end: true),
            new("Dcp16", start: true, mid: true, end: true),
            new("Dcp17", start: true, mid: true, end: true),
            new("Dcp18", start: true, mid: true, end: true),
            new("Dcp20", start: true, mid: true, end: true),
            new("Dcp21", start: true, mid: true, end: true),
            new("Dcp24", start: true, mid: true, end: true),
            new("Dcp23", start: true, mid: true, end: true),
            new("Dcp27", start: true, mid: true, end: true),
            new("Dcp29", start: true, mid: true, end: true),
            new("Dcp31", start: true, mid: true, end: true),
            new("Dcp30", start: true, mid: true, end: true),
            new("Dcp40_1", start: true, mid: true, end: true),
            new("Dcp40_2_1", start: true, mid: true, end: true),
            new("Dcp40_2_2", start: true, mid: true, end: true),
            new("Dcp40_2_3", start: true, mid: true, end: true),
            new("Dcp41", start: true, mid: true, end: true),
            new("Dcp42", start: true, mid: true, end: true),
            new("Dcp43", start: true, mid: true, end: true),
            new("Dcp45", start: true, mid: true, end: true),
            new("Dcp46", start: true, mid: true, end: true),
            new("Dcp47", start: true, mid: true, end: true),
            new("Dcp155", start: true, mid: true, end: true),
            new("Dcp79_156", start: true, mid: true, end: true),
            new("DcpSn1", start: true, mid: true, end: true),
            new("DcpSn2", start: true, mid: false, end: false),
        };
    }
}