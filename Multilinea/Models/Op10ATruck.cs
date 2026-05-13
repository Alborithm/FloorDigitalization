using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models;

public partial class Op10ATruck : ObservableValidator
{
    // ----------- DCP 22 -----------
    [ObservableProperty] private bool _dcp22Start;
    [ObservableProperty] private bool _dcp22Mid;
    [ObservableProperty] private bool _dcp22End;

    // ----------- DCP SN 33 -----------
    private const double dcpSn33LowerLimit = -.40;
    private const double dcpSn33UpperLimit = .40;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn33LowerLimit, dcpSn33UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn33Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn33LowerLimit, dcpSn33UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn33Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn33LowerLimit, dcpSn33UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn33End;

    // ----------- DCP 23 -----------
    [ObservableProperty] private bool _dcp23Start;
    [ObservableProperty] private bool _dcp23Mid;
    [ObservableProperty] private bool _dcp23End;

    // ----------- DCP 34 -----------
    [ObservableProperty] private bool _dcp34Start;
    [ObservableProperty] private bool _dcp34Mid;
    [ObservableProperty] private bool _dcp34End;
    
    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("Dcp22", start: true, mid: true, end: true),
            new("DcpSn33", start: true, mid: true, end: true),
            new("Dcp23", start: true, mid: true, end: true),
            new("Dcp34", start: true, mid: true, end: true),
        };
    }
}