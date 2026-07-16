using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op100ACtsv : ObservableValidator
{
    // ----------- DCP SN 43 -----------
    private const double dcpSn43LowerLimit = 2.5;
    private const double dcpSn43UpperLimit = 5.0;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn43LowerLimit, dcpSn43UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn43Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn43LowerLimit, dcpSn43UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn43Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn43LowerLimit, dcpSn43UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn43End;

    // ----------- DCP SN 46 -----------
    private const double dcpSn46LowerLimit = 32;
    private const double dcpSn46UpperLimit = 38;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn46LowerLimit, dcpSn46UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn46Start;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn43", start: true, mid: true, end: true),
            new("DcpSn46", start: true, mid: false, end: false),
        };
    }
}