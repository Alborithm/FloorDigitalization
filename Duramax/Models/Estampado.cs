using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using FloorDigitalization.Helpers;

namespace FloorDigitalization.Duramax.Models;

public partial class Estampado : ObservableValidator
{

    // ----------- DCP 24 -----------
    [ObservableProperty]
    private decimal? _dcp24Start;
    [ObservableProperty]
    private decimal? _dcp24Mid;
    [ObservableProperty]
    private decimal? _dcp24End;

    // ----------- DCP 74 80 -----------
    [ObservableProperty]
    private bool _dcp74_80Start;
    [ObservableProperty]
    private bool _dcp74_80Mid;
    [ObservableProperty]
    private bool _dcp74_80End;

    // ----------- DCP SN -----------
    [ObservableProperty] private bool _dcpSnStart;

    public static List<PhaseFieldMap> FieldMaps()
    {
        return new List<PhaseFieldMap>
        {
            new() { BaseName = "Dcp24",     StartHasValue = true, MidHasValue = true,   EndHasValue = true },
            new() { BaseName = "Dcp74_80",  StartHasValue = true, MidHasValue = true,   EndHasValue = true },
            new() { BaseName = "DcpSn",     StartHasValue = true, MidHasValue = false,   EndHasValue = false },  
        };
    }
}