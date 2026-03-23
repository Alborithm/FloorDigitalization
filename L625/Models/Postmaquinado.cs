using System;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.L625.Models;

public partial class Postmaquinado : ObservableValidator
{
    // --------------------- DCP SN -------------------
    [ObservableProperty] private bool _dcpSn01Start = false;
    [ObservableProperty] private bool _dcpSn01Mid = false;

    // --------------------- DCP 1/58 -------------------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1s58Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1s58Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp1s58End;

    // --------------------- DCP 3 -------------------
    
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05, 0.05, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp3Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05, 0.05, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp3Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05, 0.05, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp3End;

    // --------------------- DCP 4 -------------------

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.025, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp4Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.025, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp4Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.025, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp4End;

    // --------------------- DCP 7 -------------------

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 2.5, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp7Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 2.5, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp7Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 2.5, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp7End;

    // --------------------- DCP 9 -------------------

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.15, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp9Start;

    // --------------------- DCP 13 -------------------

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.5, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp13Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.5, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp13Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0.00, 0.5, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp13End;

    // --------------------- DCP 15 -------------------

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.15, 0.15, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp15Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.15, 0.15, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp15Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.15, 0.15, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcp15End;

    // --------------------- DCP 34 V1 -------------------

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(33.0175, 33.0425, ErrorMessage = "Valor entre 33.0175 y 33.0425")]
    private decimal? _dcp34_V_1Start;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(33.0175, 33.0425, ErrorMessage = "Valor entre 33.0175 y 33.0425")]
    private decimal? _dcp34_V_1Mid;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(33.0175, 33.0425, ErrorMessage = "Valor entre 33.0175 y 33.0425")]
    private decimal? _dcp34_V_1End;

    // --------------------- DCP 34 V2 -------------------

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(33.0175, 33.0425, ErrorMessage = "Valor entre 33.0175 y 33.0425")]
    private decimal? _dcp34_V_2Start;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(33.0175, 33.0425, ErrorMessage = "Valor entre 33.0175 y 33.0425")]
    private decimal? _dcp34_V_2Mid;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(33.0175, 33.0425, ErrorMessage = "Valor entre 33.0175 y 33.0425")]
    private decimal? _dcp34_V_2End;

    // --------------------- DCP 34 A -------------------

    [ObservableProperty] private bool _dcp34_AStart;
    [ObservableProperty] private bool _dcp34_AMid;
    [ObservableProperty] private bool _dcp34_AEnd;

    // --------------------- DCP 136 -------------------

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0, 0.05, ErrorMessage = "Valor entre 0 y 0.05")]
    private decimal? _dcp136Start;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0, 0.05, ErrorMessage = "Valor entre 0 y 0.05")]
    private decimal? _dcp136Mid;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0, 0.05, ErrorMessage = "Valor entre 0 y 0.05")]
    private decimal? _dcp136End;

    // --------------------- DCP SN 19 -------------------

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor entre 0 y 0.25")]
    private decimal? _dcpSn19Start;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor entre 0 y 0.25")]
    private decimal? _dcpSn19Mid;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor entre 0 y 0.25")]
    private decimal? _dcpSn19End;

    // --------------------- DCP SN 20 -------------------

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor entre 0 y 0.25")]
    private decimal? _dcpSn20Start;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor entre 0 y 0.25")]
    private decimal? _dcpSn20Mid;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0, 0.25, ErrorMessage = "Valor entre 0 y 0.25")]
    private decimal? _dcpSn20End;

    // --------------------- DCP 65-66 -------------------

    [ObservableProperty] private bool _dcp6566Start;
    [ObservableProperty] private bool _dcp6566Mid;
    [ObservableProperty] private bool _dcp6566End;
}