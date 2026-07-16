using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Multilinea.Models.Ctsv;

public partial class Op110ACtsv : ObservableValidator
{
    // ----------- DCP 56 57 -----------
    [ObservableProperty] private bool _dcp56_57Start;
    [ObservableProperty] private bool _dcp56_57Mid;
    [ObservableProperty] private bool _dcp56_57End;

    // ----------- DCP 156 79 -----------
    [ObservableProperty] private bool _dcp156_79Start;
    [ObservableProperty] private bool _dcp156_79Mid;
    [ObservableProperty] private bool _dcp156_79End;


    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new("Dcp56_57", start: true, mid: true, end: true),
            new("Dcp156_79", start: true, mid: true, end: true),
        };
    }
}