using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op70ACtsv : ObservableValidator
{
    // ----------- DCP SN50 -----------
    [ObservableProperty] private bool _dcpSn50Start;
    [ObservableProperty] private bool _dcpSn50Mid;
    [ObservableProperty] private bool _dcpSn50End;

    // ----------- DCP 158 -----------
    [ObservableProperty] private bool _dcp158Start;
    [ObservableProperty] private bool _dcp158Mid;
    [ObservableProperty] private bool _dcp158End;

    // ----------- DCP 39 (2 entries) -----------
    private const double dcp39LowerLimit = 0.25;
    private const double dcp39UpperLimit = 0.60;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp39LowerLimit, dcp39UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp39_1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp39LowerLimit, dcp39UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp39_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp39LowerLimit, dcp39UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp39_1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp39LowerLimit, dcp39UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp39_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp39LowerLimit, dcp39UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp39_1End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp39LowerLimit, dcp39UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp39_2End;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn50", start: true, mid: true, end: true),
            new("Dcp158", start: true, mid: true, end: true),
            new("Dcp39_1", start: true, mid: true, end: true),
            new("Dcp39_2", start: true, mid: true, end: true),
        };
    }
}