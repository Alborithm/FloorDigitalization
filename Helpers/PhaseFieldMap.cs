namespace FloorDigitalization.Helpers;

public class PhaseFieldMap
{
    public string BaseName { get; set; } = string.Empty;
    public bool StartHasValue { get; set; }
    public bool MidHasValue { get; set; }
    public bool EndHasValue { get; set; }

    public PhaseFieldMap()
    {
        
    }

    public PhaseFieldMap(string baseName, bool start, bool mid, bool end)
    {
        BaseName = baseName;
        StartHasValue = start;
        MidHasValue = mid;
        EndHasValue = end;
    }
}