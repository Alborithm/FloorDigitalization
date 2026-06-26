using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op10WCtsv : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP SN 51 -----------
    private const double dcpSn51LowerLimit = 0.0;
    private const double dcpSn51UpperLimit = 0.15;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn51LowerLimit, dcpSn51UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn51Start;

    // ----------- DCP 119 -----------
    private const double dcp119LowerLimit = -.25;
    private const double dcp119UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp119LowerLimit, dcp119UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp119Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp119LowerLimit, dcp119UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp119Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp119LowerLimit, dcp119UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp119End;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn", start: true, mid: true, end: false),
            new("DcpSn51", start: true, mid: false, end: false),
            new("Dcp119", start: true, mid: true, end: true),
        };
    }
}