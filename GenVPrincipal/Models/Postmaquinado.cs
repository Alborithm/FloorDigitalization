using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.GenVPrincipal.Models;

public partial class Postmaquinado : ObservableValidator
{
    // ----------- DCP SN01 ----------- (bool / Start,Mid only)
    [ObservableProperty]
    private bool _dcpSn01Start;

    [ObservableProperty]
    private bool _dcpSn01Mid;

    // ----------- DCP 1 ----------- (-0.25 to 0.25)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1End;

    // ----------- DCP 2 ----------- (-0.25 to 0.25)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp2Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp2Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp2End;

    // ----------- DCP 4 ----------- (-0.25 to 0.25)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp4Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp4Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp4End;

    // ----------- DCP 5 ----------- (-0.25 to 0.25)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp5Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp5Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp5End;

    // ----------- DCP 9A ----------- (0 to 0.25)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp9aStart;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp9aMid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp9aEnd;


    // ----------- DCP 9B ----------- (0 to 0.25)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp9bStart;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp9bMid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp9bEnd;


    // ----------- DCP 12 ----------- 
    [ObservableProperty]
    private bool _dcp12Start;

    [ObservableProperty]
    private bool _dcp12Mid;

    [ObservableProperty]
    private bool _dcp12End;


    // ----------- DCP 16 ----------- (0 to 0.025)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.025, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp16Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.025, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp16Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.025, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp16End;


    // ----------- DCP 38 ----------- (1.25 to 2.5)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(1.25, 2.5, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp38Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(1.25, 2.5, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp38Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(1.25, 2.5, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp38End;


    // ----------- DCP 6 ----------- (-0.25 to 0.25)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp6Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp6Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp6End;


    // ----------- DCP 7 ----------- (0 to 0.6)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.6, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp7Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.6, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp7Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.6, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp7End;


    // ----------- DCP 18 ----------- (bool)
    [ObservableProperty]
    private bool _dcp18Start;

    [ObservableProperty]
    private bool _dcp18Mid;

    [ObservableProperty]
    private bool _dcp18End;


    // ----------- DCP 22 ----------- (0 to 0.05)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.05, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp22Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.05, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp22Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.05, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp22End;


    // ----------- DCP 24 ----------- (0 to 0.125)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.125, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp24Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.125, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp24Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 0.125, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp24End;


    // ----------- DCP 25 ----------- (-0.25 to 0.25)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp25Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp25Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp25End;


    // ----------- DCP 26 ----------- (-0.25 to 0.25)
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp26Start;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp26Mid;

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp26End;


    // ----------- DCP 20IP ----------- (0 to 2) Mid/End = FALSE in CSV
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0, 2, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp20ipStart;

    // Mid and End exist but are FALSE → You may want them not to exist.
    // If you still want the properties, uncomment:
    //
    // [ObservableProperty] private decimal? _dcp20ipMid;
    // [ObservableProperty] private decimal? _dcp20ipEnd;


    // ----------- DCP 42 ----------- (bool)
    [ObservableProperty]
    private bool _dcp42Start;

    [ObservableProperty]
    private bool _dcp42Mid;

    [ObservableProperty]
    private bool _dcp42End;
}
