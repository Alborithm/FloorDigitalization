using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Truck;

public partial class Op90ATruck : ObservableValidator
{
    // ----------- DCP Sn74 -----------
    [ObservableProperty] private bool _dcpSn74Start;
    [ObservableProperty] private bool _dcpSn74Mid;
    [ObservableProperty] private bool _dcpSn74End;

    // ----------- DCP Sn75 -----------
    [ObservableProperty] private bool _dcpSn75Start;
    [ObservableProperty] private bool _dcpSn75Mid;
    [ObservableProperty] private bool _dcpSn75End;

    // ----------- DCP 82 85 -----------
    [ObservableProperty] private bool _dcp82_85Start;
    [ObservableProperty] private bool _dcp82_85Mid;
    [ObservableProperty] private bool _dcp82_85End;

    // // ----------- DCP 82 85 -----------
    // private const double dcp82_85LowerLimit = .25;
    // private const double dcp82_85UpperLimit = .6;

    // [ObservableProperty][NotifyDataErrorInfo]
    // [Range(dcp82_85LowerLimit, dcp82_85UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    // private decimal? _dcp82_85Start;
    // [ObservableProperty][NotifyDataErrorInfo]
    // [Range(dcp82_85LowerLimit, dcp82_85UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    // private decimal? _dcp82_85Mid;
    // [ObservableProperty][NotifyDataErrorInfo]
    // [Range(dcp82_85LowerLimit, dcp82_85UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    // private decimal? _dcp82_85End;
    
    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn74", start: true, mid: true, end: true),
            new("DcpSn75", start: true, mid: true, end: true),
            new("Dcp82_85", start: true, mid: true, end: true),
        };
    }
}