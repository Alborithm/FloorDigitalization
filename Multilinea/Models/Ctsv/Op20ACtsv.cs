using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op20ACtsv : ObservableValidator
{
    // ----------- DCP SN 15 -----------
    private const double dcpSn15LowerLimit = -.1;
    private const double dcpSn15UpperLimit = .1;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn15LowerLimit, dcpSn15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn15_1Start;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn15LowerLimit, dcpSn15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn15_2Start;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn15LowerLimit, dcpSn15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn15_3Start;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn15LowerLimit, dcpSn15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn15_1Mid;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn15LowerLimit, dcpSn15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn15_2Mid;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn15LowerLimit, dcpSn15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn15_3Mid;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn15LowerLimit, dcpSn15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn15_1End;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn15LowerLimit, dcpSn15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn15_2End;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn15LowerLimit, dcpSn15UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn15_3End;

    // ----------- DCP 78 -----------
    [ObservableProperty] private bool _dcp78Start;
    [ObservableProperty] private bool _dcp78Mid;
    [ObservableProperty] private bool _dcp78End;

    // ----------- DCP 79 156 -----------
    [ObservableProperty] private bool _dcp79_156Start;
    [ObservableProperty] private bool _dcp79_156Mid;
    [ObservableProperty] private bool _dcp79_156End;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn15_1", start: true, mid: true, end: true),
            new("DcpSn15_2", start: true, mid: true, end: true),
            new("DcpSn15_3", start: true, mid: true, end: true),
            new("Dcp78", start: true, mid: true, end: true),
            new("Dcp79_156", start: true, mid: true, end: true),
        };
    }
}