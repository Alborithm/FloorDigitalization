using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models;

public partial class Op10WTruck : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP SN 20 -----------
    private const double dcpSn20LowerLimit = -.25;
    private const double dcpSn20UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn20LowerLimit, dcpSn20UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn20Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn20LowerLimit, dcpSn20UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn20Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn20LowerLimit, dcpSn20UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn20End;

    // ----------- DCP SN 81 -----------
    private const double dcpSn81LowerLimit = 52.05;
    private const double dcpSn81UpperLimit = 52.55;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn81LowerLimit, dcpSn81UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn81Start;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn", start: true, mid: true, end: false),
            new("DcpSn20", start: true, mid: true, end: true),
            new("DcpSn81", start: true, mid: false, end: false),
        };
    }
}