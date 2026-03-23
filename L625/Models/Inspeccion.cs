using System;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.L625.Models;

public partial class Inspeccion : ObservableValidator
{
    
    [ObservableProperty]
    private bool _dcp34Start;
    [ObservableProperty]
    private bool _dcp34Mid;
    [ObservableProperty]
    private bool _dcp34End;
    [ObservableProperty]
    private bool _dcp64Start;
    [ObservableProperty]
    private bool _dcp64Mid;
    [ObservableProperty]
    private bool _dcp64End;
    [ObservableProperty]
    private bool _dcpSn23Start;
    [ObservableProperty]
    private bool _dcpSn23Mid;
    [ObservableProperty]
    private bool _dcpSn23End;
    [ObservableProperty]
    private bool _dcp67Start;
    [ObservableProperty]
    private bool _dcp67Mid;
    [ObservableProperty]
    private bool _dcp67End;
    [ObservableProperty]
    private bool _dcp53Start;
    [ObservableProperty]
    private bool _dcp53Mid;
    [ObservableProperty]
    private bool _dcp53End;
    [ObservableProperty]
    private bool _dcp54Start;
    [ObservableProperty]
    private bool _dcp54Mid;
    [ObservableProperty]
    private bool _dcp54End;
    [ObservableProperty]
    private bool _dcp65Start;
    [ObservableProperty]
    private bool _dcp65Mid;
    [ObservableProperty]
    private bool _dcp65End;
    [ObservableProperty]
    private bool _dcp66Start;
    [ObservableProperty]
    private bool _dcp66Mid;
    [ObservableProperty]
    private bool _dcp66End;
    [ObservableProperty]
    private bool _dcpSn_1Start;
    [ObservableProperty]
    private bool _dcpSn_1Mid;
    [ObservableProperty]
    private bool _dcpSn_1End;
    [ObservableProperty]
    private bool _dcpSn_2Start;
    [ObservableProperty]
    private bool _dcpSn_2Mid;
    [ObservableProperty]
    private bool _dcpSn_2End;
    
}