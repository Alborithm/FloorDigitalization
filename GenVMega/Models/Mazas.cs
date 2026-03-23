using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.GenVMega.Models;

public partial class Mazas : ObservableValidator
{
    // ----------- DCPSN
    [ObservableProperty]
    private bool _dcpSn01Start;
    [ObservableProperty]
    private bool _dcpSn01Mid;
    // ----------- DCPSN
    [ObservableProperty]
    private bool _dcpSn02Start;
    [ObservableProperty]
    private bool _dcpSn02Mid;
    // ----------- DCP 174
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.10,.10, ErrorMessage = "Valor fuera de especificación ({1} a {2} mm)")]
    private decimal? _dcp174_1Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.10,.10, ErrorMessage = "Valor fuera de especificación ({1} a {2} mm)")]
    private decimal? _dcp174_1Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.10,.10, ErrorMessage = "Valor fuera de especificación ({1} a {2} mm)")]
    private decimal? _dcp174_1End;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.10,.10, ErrorMessage = "Valor fuera de especificación  ({1} a {2} mm)")]
    private decimal? _dcp174_2Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.10,.10, ErrorMessage = "Valor fuera de especificación  ({1} a {2} mm)")]
    private decimal? _dcp174_2Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.10,.10, ErrorMessage = "Valor fuera de especificación  ({1} a {2} mm)")]
    private decimal? _dcp174_2End;
    // ----------- DCP 172
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.05,.05, ErrorMessage = "Valor fuera de especificación  ({1} a {2} mm)")]
    private decimal? _dcp172Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.05,.05, ErrorMessage = "Valor fuera de especificación  ({1} a {2} mm)")]
    private decimal? _dcp172Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.05,.05, ErrorMessage = "Valor fuera de especificación  ({1} a {2} mm)")]
    private decimal? _dcp172End;
    // ----------- DCP 173
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.25,.25, ErrorMessage = "Valor fuera de especificación  ({1} a {2} mm)")]
    private decimal? _dcp173Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.25,.25, ErrorMessage = "Valor fuera de especificación  ({1} a {2} mm)")]
    private decimal? _dcp173Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-.25,.25, ErrorMessage = "Valor fuera de especificación  ({1} a {2} mm)")]
    private decimal? _dcp173End;
    // ----------- DCP 42 IP
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(35.30,35.70, ErrorMessage = "Valor fuera de especificación  ({1} a {2} mm)")]
    private decimal? _dcp42_IpStart;
    // ----------- DCP 77 161
    [ObservableProperty]
    private bool _dcp77_161Start;
    [ObservableProperty]
    private bool _dcp77_161Mid;
    [ObservableProperty]
    private bool _dcp77_161End;
}