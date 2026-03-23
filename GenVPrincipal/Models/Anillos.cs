using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.GenVPrincipal.Models;

public partial class Anillos : ObservableValidator
{
    // ------------------ DPC SN 01 -----------------
    [ObservableProperty]
    private bool _dcpSn01Start;
    [ObservableProperty]
    private bool _dcpSn01Mid;
    // ------------------ DPC 133 -----------------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.1,.1, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp133Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.1,.1, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp133Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.1,.1, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp133End;
    // ------------------ DPC 134 -----------------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.1,.1, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp134Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.1,.1, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp134Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.1,.1, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp134End;
    // ------------------ DPC 8 -----------------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.3,.3, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp8_1Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.3,.3, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp8_1Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.3,.3, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp8_1End;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.3,.3, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp8_2Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.3,.3, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp8_2Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.3,.3, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp8_2End;

    // ------------------ DPC 11 -----------------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0,0.35, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp11_1Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0,0.35, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp11_1Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0,0.35, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp11_1End;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0,0.35, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp11_2Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0,0.35, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp11_2Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0,0.35, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp11_2End;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0,0.35, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp11_3Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0,0.35, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp11_3Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0,0.35, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp11_3End;

    // ------------------ DPC 130 -----------------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp130Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp130Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp130End;

    // ------------------ DPC 160 -----------------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05,0.05, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp160Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05,0.05, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp160Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05,0.05, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp160End;

    // ------------------ DPC 132 -----------------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05,0.05, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp132_1Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05,0.05, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp132_1Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05,0.05, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp132_1End;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05,0.05, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp132_2Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05,0.05, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp132_2Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.05,0.05, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp132_2End;

    // ------------------ DPC 10 -----------------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp10_1Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp10_1Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp10_1End;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp10_2Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp10_2Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp10_2End;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp10_3Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp10_3Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25,0.25, ErrorMessage = "Valor fuera de especificación ({0} a {1} mm)")]
    private decimal? _dcp10_3End;

    // ------------------ DPC 131 -----------------
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(0,0.1, ErrorMessage = "Valor fuera de especificación ({0} a {1})")]
    private decimal? _dcp131Start;

    // ------------------ DPC 77 161 -----------------
    [ObservableProperty]
    private bool _dcp77_161Start;
    [ObservableProperty]
    private bool _dcp77_161Mid;
    [ObservableProperty]
    private bool _dcp77_161End;

    // ------------------ DPC SN 02 -----------------
    [ObservableProperty]
    private bool _dcpSn02Start;
}