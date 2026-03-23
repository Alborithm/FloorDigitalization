using System.ComponentModel.DataAnnotations;
using Avalonia.Controls.Documents;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace FloorDigitalization.Helpers;

public partial class DcpItem : ObservableValidator
{
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? BoldDescription { get; set; }
    public string? Gage { get; set; }
    public string? Sample { get; set; }
    public string? InspectionFrequency { get; set; }

    public bool HasStart1 { get; set; } = false;
    public bool HasStart2 { get; set; } = false;
    public bool HasStart3 { get; set; } = false;
    public bool HasMid1 { get; set; } = false;
    public bool HasMid2 { get; set; } = false;
    public bool HasMid3 { get; set; } = false;
    public bool HasEnd1 { get; set; } = false;
    public bool HasEnd2 { get; set; } = false;
    public bool HasEnd3 { get; set; } = false;

    // THIS is the important part
    public string? StartProperty { get; set; }
    public string? MidProperty { get; set; }
    public string? EndProperty { get; set; }
    public decimal? LowerLimit = null;
    public decimal? UpperLimit = null; 
    [ObservableProperty]
    private decimal? _startValue1 = null;
    public object? MidValue1 { get; set; }
    public object? EndValue1 { get; set; }
    public object? StartValue2 { get; set; }    
    public object? MidValue2 { get; set; }
    public object? EndValue2 { get; set; }
    public object? StartValue3 { get; set; }    
    public object? MidValue3 { get; set; }
    public object? EndValue3 { get; set; }

    public bool IsCheckBox { get; set; }   // true → checkbox, false → textbox

    public class Box<T>
    {
        public T? Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }
    }

    public DcpItem()
    {
        StartValue1 = 10;
    }

    // public DcpItem(string code, string description, string? boldDescription, string gage, string sample, string inspectionFrequency, string registerFrequency, object? startValue, object? midValue, object? endValue, bool isCheckBox)
    // {
    //     Code = code;
    //     Description = description;
    //     BoldDescription = BoldDescription;
    //     Gage = gage;
    //     Sample = sample;
    //     InspectionFrequency = inspectionFrequency;
    //     RegisterFrequency = registerFrequency;
    //     StartValue = startValue;
    //     MidValue = midValue;
    //     EndValue = endValue;
    //     IsCheckBox = isCheckBox;
    // }
}
