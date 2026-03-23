using System;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.L625.Models;

public partial class Balanceo : ObservableValidator
{
    private decimal? _dcp60Start;
    [Range(0,180, ErrorMessage = "Valor debe de estar entre 0 y 180 g/mm.")]
    public decimal? Dcp60Start
    {
        get => _dcp60Start;
        set => SetProperty(ref _dcp60Start, value, true);
    }
    [ObservableProperty]
    private bool _dcp30Start;
    [ObservableProperty]
    private bool _dcp31Start;
    [ObservableProperty]
    private bool _dcp31Mid;
    [ObservableProperty]
    private bool _dcp31End;
    [ObservableProperty]
    private bool _dcp33Start;
    [ObservableProperty]
    private bool _dcp65_66Start;
    [ObservableProperty]
    private bool _dcp65_66Mid;
    [ObservableProperty]
    private bool _dcp65_66End;
    [ObservableProperty]
    private bool _dcp35Start;
    [ObservableProperty]
    private bool _dcp35Mid;
    [ObservableProperty]
    private bool _dcp35End;
    
}