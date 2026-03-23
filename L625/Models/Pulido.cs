using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.L625.Models;

public partial class Pulido : ObservableValidator
{
    // --------------------- DCP 14 -------------------

    [ObservableProperty] private bool _dcp14Start;
    [ObservableProperty] private bool _dcp14Mid;
    [ObservableProperty] private bool _dcp14End;

    // --------------------- DCP 19 Ra -------------------

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0.25, 0.80, ErrorMessage = "Valor entre 0.25 y 0.80")]
    private decimal? _dcp19RaStart;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0.25, 0.80, ErrorMessage = "Valor entre 0.25 y 0.80")]
    private decimal? _dcp19RaMid;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(0.25, 0.80, ErrorMessage = "Valor entre 0.25 y 0.80")]
    private decimal? _dcp19RaEnd;

    // --------------------- DCP 19 Rz -------------------

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(1.5, 6.0, ErrorMessage = "Valor entre 1.5 y 6.0")]
    private decimal? _dcp19RzStart;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(1.5, 6.0, ErrorMessage = "Valor entre 1.5 y 6.0")]
    private decimal? _dcp19RzMid;

    [ObservableProperty, NotifyDataErrorInfo]
    [Range(1.5, 6.0, ErrorMessage = "Valor entre 1.5 y 6.0")]
    private decimal? _dcp19RzEnd;

    // --------------------- DCP SN 22 -------------------

    [ObservableProperty] private bool _dcpSn22Start;
    [ObservableProperty] private bool _dcpSn22Mid;
    [ObservableProperty] private bool _dcpSn22End;
}