using System.Collections.Generic;
using System.Threading.Channels;
using Avalonia.Remote.Protocol.Designer;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FloorDigitalization.Helpers.Dcps;

public class Dcp
{
    public required string Code { get; set; }
    public required string Description { get; set; }
    public string BoldDescription { get; set; } = string.Empty;
    public string PostDescription { get; set; } = string.Empty;
    public required string Gage { get; set; }
    public required string Sample { get; set; }
    public required string InspectFrequency { get; set; }
    public required bool IsCheckBox { get; set; }
    public string? ParentName { get; set; }
    public int InputPerTurn { get; set; }
    public bool HasStart { get; set; }
    public bool HasMid { get; set; }
    public bool HasEnd { get; set; }
    // public string? DcpName { get; set; }
    // public string? Start1Property { get; set; }
    // public string? Start2Property { get; set; }
    // public string? Start3Property { get; set; }

    // public string? Mid1Property { get; set; }
    // public string? Mid2Property { get; set; }
    // public string? Mid3Property { get; set; }
    // public string? End1Property { get; set; }
    // public string? End2Property { get; set; }
    // public string? End3Property { get; set; }
    public List<string> DcpValues { get; init; } = new List<string>();

    /// <summary>
    /// Constructor for Dcp class
    /// </summary>
    /// <param name="code">The Dcp code as in Dcp60</param>
    /// <param name="inputPerTurn">How many field per shift time does it have, max 3</param>
    /// <param name="start">Has Start registry</param>
    /// <param name="mid"></param>
    /// <param name="end"></param>
    public Dcp(string code, int inputPerTurn, bool start, bool mid, bool end)
    {
        HasStart = start;
        HasMid = mid;
        HasEnd = end;
        bool HasAny = (!start && !mid && !end)? true : false;
        InputPerTurn = inputPerTurn;
        if (inputPerTurn == 1)
        {
            if (start)
            {
                DcpValues.Add($"{code}Start");
                // Start1Property = $"{code}Start";
            }
            if (mid)
            {
                DcpValues.Add($"{code}Mid");
                // Mid1Property = $"{code}Mid";
            }
            if (end)
            {
                DcpValues.Add($"{code}End");
                // End1Property = $"{code}End";
            }
            if (HasAny)
            {
                DcpValues.Add($"{code}Any");
            }
        }
        if (inputPerTurn >= 2)
        {
            if (start)
            {
                DcpValues.Add($"{code}_1Start");
                DcpValues.Add($"{code}_2Start");
                // Start1Property = $"{code}_1Start";
                // Start2Property = $"{code}_2Start";
            }
            if (mid)
            {
                DcpValues.Add($"{code}_1Mid");
                DcpValues.Add($"{code}_2Mid");
                // Mid1Property = $"{code}_1Mid";
                // Mid2Property = $"{code}_2Mid";
            }
            if (end)
            {
                DcpValues.Add($"{code}_1End");
                DcpValues.Add($"{code}_2End");
                // End1Property = $"{code}_1End";
                // End2Property = $"{code}_2End";
            }
        }
        if (inputPerTurn == 3)
        {
            if (start)
            {
                DcpValues.Add($"{code}_3Start");
                // Start3Property = $"{code}_3Start";
            }
            if (mid)
            {
                DcpValues.Add($"{code}_3Mid");
                // Mid3Property = $"{code}_3Mid";
            }
            if (end)
            {
                DcpValues.Add($"{code}_3End");
                // End3Property = $"{code}_3End";
            }
        }
        if (inputPerTurn >= 4)
        {
            throw new System.Exception("Dcp can only have up to 3 inputs per turn for now");
        }
    }

    public Dcp()
    {
    }

}