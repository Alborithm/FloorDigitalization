using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Truck;

public partial class Op30ATruck : ObservableValidator
{
    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;
    [ObservableProperty] private bool _dcpSnMid;

    // ----------- DCP SN 80 -----------
    private const double dcpSn80LowerLimit = .90;
    private const double dcpSn80UpperLimit = 1.5;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn80LowerLimit, dcpSn80UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcpSn80Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcpSn80LowerLimit, dcpSn80UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn80Mid;

    // ----------- DCP 49 -----------
    private const double dcp49LowerLimit = -.100;
    private const double dcp49UpperLimit = .100;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp49LowerLimit, dcp49UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp49Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp49LowerLimit, dcp49UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp49Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp49LowerLimit, dcp49UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp49End;

    // ----------- DCP 50 -----------
    private const double dcp50LowerLimit = 0.0;
    private const double dcp50UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp50LowerLimit, dcp50UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp50Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp50LowerLimit, dcp50UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp50Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp50LowerLimit, dcp50UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp50End;

    // ----------- DCP 51 -----------
    private const double dcp51LowerLimit = -.25;
    private const double dcp51UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp51LowerLimit, dcp51UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp51Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp51LowerLimit, dcp51UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp51Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp51LowerLimit, dcp51UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp51End;

    // ----------- DCP 52 -----------
    private const double dcp52LowerLimit = 0.0;
    private const double dcp52UpperLimit = .25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp52LowerLimit, dcp52UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp52Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp52LowerLimit, dcp52UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp52Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp52LowerLimit, dcp52UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp52End;
    
    // ----------- DCP 58 -----------
    private const double dcp58LowerLimit = -0.30;
    private const double dcp58UpperLimit = 0.30;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp58LowerLimit, dcp58UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp58Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp58LowerLimit, dcp58UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp58Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp58LowerLimit, dcp58UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp58End;

    // ----------- DCP 60 -----------
    private const double dcp60LowerLimit = 0.0;
    private const double dcp60UpperLimit = 0.35;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp60LowerLimit, dcp60UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp60Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp60LowerLimit, dcp60UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp60Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp60LowerLimit, dcp60UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp60End;

    // ----------- DCP 61 -----------
    private const double dcp61LowerLimit = 0.0;
    private const double dcp61UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp61LowerLimit, dcp61UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp61Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp61LowerLimit, dcp61UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp61Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp61LowerLimit, dcp61UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp61End;

    // ----------- DCP 66 -----------
    private const double dcp66LowerLimit = -0.25;
    private const double dcp66UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp66LowerLimit, dcp66UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp66Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp66LowerLimit, dcp66UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp66Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp66LowerLimit, dcp66UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp66End;

    // ----------- DCP 67 -----------
    private const double dcp67LowerLimit = 0.0;
    private const double dcp67UpperLimit = 0.125;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp67LowerLimit, dcp67UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp67Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp67LowerLimit, dcp67UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp67Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp67LowerLimit, dcp67UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp67End;

    // ----------- DCP 72 -----------
    [ObservableProperty] private bool _dcp72Start;
    [ObservableProperty] private bool _dcp72Mid;
    [ObservableProperty] private bool _dcp72End;

    // ----------- DCP 73 -----------
    private const double dcp73LowerLimit = 0.0;
    private const double dcp73UpperLimit = 0.25;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp73LowerLimit, dcp73UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp73Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp73LowerLimit, dcp73UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp73Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp73LowerLimit, dcp73UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp73End;

    // ----------- DCP 87_1 (3 records)-----------
    private const double dcp87_1LowerLimit = 37.600;
    private const double dcp87_1UpperLimit = 37.625;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp87_1LowerLimit, dcp87_1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp87_1_1Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp87_1LowerLimit, dcp87_1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp87_1_2Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp87_1LowerLimit, dcp87_1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp87_1_3Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp87_1LowerLimit, dcp87_1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp87_1_1Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp87_1LowerLimit, dcp87_1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp87_1_2Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp87_1LowerLimit, dcp87_1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp87_1_3Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp87_1LowerLimit, dcp87_1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp87_1_1End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp87_1LowerLimit, dcp87_1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp87_1_2End;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp87_1LowerLimit, dcp87_1UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp87_1_3End;

    // ----------- DCP 75 -----------
    private const double dcp75LowerLimit = 0.0;
    private const double dcp75UpperLimit = 0.35;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp75LowerLimit, dcp75UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp75Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp75LowerLimit, dcp75UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp75Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp75LowerLimit, dcp75UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp75End;

    // ----------- DCP 87_2 -----------
    [ObservableProperty] private bool _dcp87_2Start;
    [ObservableProperty] private bool _dcp87_2Mid;
    [ObservableProperty] private bool _dcp87_2End;

    // ----------- DCP 88 -----------
    private const double dcp88LowerLimit = 1.25;
    private const double dcp88UpperLimit = 2.5;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp88LowerLimit, dcp88UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp88Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp88LowerLimit, dcp88UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp88Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp88LowerLimit, dcp88UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp88End;

    // ----------- DCP 89 -----------
    private const double dcp89LowerLimit = -.065;
    private const double dcp89UpperLimit = 0.065;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp89LowerLimit, dcp89UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp89Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp89LowerLimit, dcp89UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp89Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp89LowerLimit, dcp89UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp89End;

    // ----------- DCP 90 -----------
    private const double dcp90LowerLimit = 0.0;
    private const double dcp90UpperLimit = 0.025;

    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp90LowerLimit, dcp90UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp90Start;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp90LowerLimit, dcp90UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp90Mid;
    [ObservableProperty][NotifyDataErrorInfo]
    [Range(dcp90LowerLimit, dcp90UpperLimit, ErrorMessage = "Valor fuera de especificación ({1} a {2})")] 
    private decimal? _dcp90End;

    // ----------- DCP 94 -----------
    [ObservableProperty] private bool _dcp94Start;
    [ObservableProperty] private bool _dcp94Mid;
    [ObservableProperty] private bool _dcp94End;

    // ----------- DCP SN_1 -----------
    [ObservableProperty] private bool _dcpSn_1Start;
    [ObservableProperty] private bool _dcpSn_1Mid;
    [ObservableProperty] private bool _dcpSn_1End;

    // ----------- DCP SN_2 -----------
    [ObservableProperty] private bool _dcpSn_2Start;

    
    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("DcpSn", start: true, mid: true, end: false),
            new("DcpSn80", start: true, mid: true, end: false),
            new("Dcp49", start: true, mid: true, end: true),
            new("Dcp50", start: true, mid: true, end: true),
            new("Dcp51", start: true, mid: true, end: true),
            new("Dcp52", start: true, mid: true, end: true),
            new("Dcp58", start: true, mid: true, end: true),
            new("Dcp60", start: true, mid: true, end: true),
            new("Dcp61", start: true, mid: true, end: true),
            new("Dcp66", start: true, mid: true, end: true),
            new("Dcp67", start: true, mid: true, end: true),
            new("Dcp72", start: true, mid: true, end: true),
            new("Dcp73", start: true, mid: true, end: true),
            new("Dcp87_1_1", start: true, mid: true, end: true),
            new("Dcp87_1_2", start: true, mid: true, end: true),
            new("Dcp87_1_3", start: true, mid: true, end: true),
            new("Dcp75", start: true, mid: true, end: true),
            new("Dcp87_2", start: true, mid: true, end: true),
            new("Dcp88", start: true, mid: true, end: true),
            new("Dcp89", start: true, mid: true, end: true),
            new("Dcp90", start: true, mid: true, end: true),
            new("Dcp94", start: true, mid: true, end: true),
            new("DcpSn_1", start: true, mid: true, end: true),
            new("DcpSn_2", start: true, mid: false, end: false),
        };
    }
}