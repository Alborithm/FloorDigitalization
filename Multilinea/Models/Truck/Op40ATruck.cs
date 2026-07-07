using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Truck;

public partial class Op40ATruck : ObservableValidator
{
    // ----------- DCP 68 -----------
    [ObservableProperty] private bool _dcp68Start;
    [ObservableProperty] private bool _dcp68Mid;

    // ----------- DCP 69 -----------
    [ObservableProperty] private bool _dcp69Start;
    [ObservableProperty] private bool _dcp69Mid;
    [ObservableProperty] private bool _dcp69End;

    // ----------- DCP 86 -----------
    [ObservableProperty] private bool _dcp86Start;
    [ObservableProperty] private bool _dcp86Mid;
    [ObservableProperty] private bool _dcp86End;

    // ----------- DCP 87 -----------
    [ObservableProperty] private bool _dcp87Start;
    [ObservableProperty] private bool _dcp87Mid;
    [ObservableProperty] private bool _dcp87End;

    // ----------- DCP 23 -----------
    [ObservableProperty] private bool _dcp23Start;
    [ObservableProperty] private bool _dcp23Mid;
    [ObservableProperty] private bool _dcp23End;

    // ----------- DCP 34 -----------
    [ObservableProperty] private bool _dcp34Start;
    [ObservableProperty] private bool _dcp34Mid;
    [ObservableProperty] private bool _dcp34End;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("Dcp68", start: true, mid: true, end: false),
            new("Dcp69", start: true, mid: true, end: true),
            new("Dcp86", start: true, mid: true, end: true),
            new("Dcp87", start: true, mid: true, end: true),
            new("Dcp23", start: true, mid: true, end: true),
            new("Dcp34", start: true, mid: true, end: true),
        };
    }
}