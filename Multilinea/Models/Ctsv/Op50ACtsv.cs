using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op50ACtsv : ObservableValidator
{
    // ----------- DCP 37 -----------
    [ObservableProperty] private bool _dcp37Start;

    // ----------- DCP 51 38 -----------
    [ObservableProperty] private bool _dcp51_38Start;
    [ObservableProperty] private bool _dcp51_38Mid;
    [ObservableProperty] private bool _dcp51_38End;

    // ----------- DCP 40 -----------
    [ObservableProperty] private bool _dcp40Start;
    [ObservableProperty] private bool _dcp40Mid;
    [ObservableProperty] private bool _dcp40End;

    // ----------- DCP 79 156 -----------
    [ObservableProperty] private bool _dcp79_156Start;
    [ObservableProperty] private bool _dcp79_156Mid;
    [ObservableProperty] private bool _dcp79_156End;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("Dcp37", start: true, mid: false, end: false),
            new("Dcp51_38", start: true, mid: true, end: true),
            new("Dcp40", start: true, mid: true, end: true),
            new("Dcp79_156", start: true, mid: true, end: true),
        };
    }
}