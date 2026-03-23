using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Models;

public partial class User : ObservableObject
{
    [ObservableProperty]
    private int? nomina;
    [ObservableProperty]
    private string? name;
    public DateTime Date { get; set; } = DateTime.Today;
    public int Shift { get; set; } = 1;
}