using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op20WCtsv : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP 116 -----------
    private const double dcp116LowerLimit = -.25;
    private const double dcp116UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp116LowerLimit, dcp116UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp116Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp116LowerLimit, dcp116UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp116Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp116LowerLimit, dcp116UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp116End;

    // ----------- DCP 118 -----------
    private const double dcp118LowerLimit = -.08;
    private const double dcp118UpperLimit = .08;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp118LowerLimit, dcp118UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp118Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp118LowerLimit, dcp118UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp118Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp118LowerLimit, dcp118UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp118End;

    // ----------- DCP 127 -----------
    private const double dcp127LowerLimit = -.05;
    private const double dcp127UpperLimit = .05;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp127LowerLimit, dcp127UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp127Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp127LowerLimit, dcp127UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp127Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp127LowerLimit, dcp127UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp127End;

    // ----------- DCP 79 156 -----------
    [ObservableProperty] private bool _dcp79_156Start;
    [ObservableProperty] private bool _dcp79_156Mid;
    [ObservableProperty] private bool _dcp79_156End;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn", start: true, mid: true, end: false),
            new("Dcp116", start: true, mid: true, end: true),
            new("Dcp118", start: true, mid: true, end: true),
            new("Dcp127", start: true, mid: true, end: true),
            new("Dcp79_156", start: true, mid: false, end: true),
        };
    }
}