using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.GenVMega.Models;

public partial class Ensamble : ObservableValidator
{
    [ObservableProperty]
    private bool _dcp76Start;
    [ObservableProperty]
    private bool _dcp76Mid;
    [ObservableProperty]
    private bool _dcp76End;
}