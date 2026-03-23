using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.L625.Models;

public partial class Cunero : ObservableValidator
{
    // --------------------- DCP 28 -------------------

    [ObservableProperty] private bool _dcp28Start = false;

    // --------------------- DCP 32 -------------------
    [ObservableProperty] private bool _dcp32Start = false;
    [ObservableProperty] private bool _dcp32Mid = false;
    [ObservableProperty] private bool _dcp32End = false;

    // --------------------- DCP 65 66 -------------------
    [ObservableProperty] private bool _dcp6566Start = false;
    [ObservableProperty] private bool _dcp6566Mid = false;
    [ObservableProperty] private bool _dcp6566End = false;
}