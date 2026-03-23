using System;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.L625.Models;

public partial class Ensamble : ObservableValidator
{
    // ------------- DCP SN01 ------------
    [ObservableProperty]
    public bool _dcpSn01Start = false;
    [ObservableProperty]
    private bool _dcpSn01Mid = false;


    // ------------- DCP SN02 ------------

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn02Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn02Mid;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(-0.25, 0.25, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn02End;

    // ------------- DCP SN02 ------------

    [ObservableProperty]
    private bool _dcp64Start = false;
    [ObservableProperty]
    private bool _dcp64Mid = false;
    [ObservableProperty]
    private bool _dcp64End = false;

    // ------------- DCP 67 ------------
    
    [ObservableProperty]
    private bool _dcp67Start = false;
    [ObservableProperty]
    private bool _dcp67Mid = false;
    [ObservableProperty]
    private bool _dcp67End = false;
    
    // ------------- DCP SN 32 ------------
    
    [ObservableProperty]
    private bool _dcpSn32Start = false;

    // ------------- DCP SN 18 ------------
    
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(16.00, 22.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn18_1Start;
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Range(16.00, 22.00, ErrorMessage = "Valor fuera de especificación ({1} a {2})")]
    private decimal? _dcpSn18_2Start;

    // ------------- DCP SN 17 ------------

    [ObservableProperty]
    private bool _dcpSn17Start = false;
    [ObservableProperty]
    private bool _dcpSn17Mid = false;
    [ObservableProperty]
    private bool _dcpSn17End = false;
    
    // ------------- DCP SN 03 ------------
    
    [ObservableProperty]
    private bool _dcpSn03Start = false;
    [ObservableProperty]
    private bool _dcpSn03Mid = false;
    [ObservableProperty]
    private bool _dcpSn03End = false;
}