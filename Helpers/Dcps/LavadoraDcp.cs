namespace FloorDigitalization.Helpers.Dcps;

public class LavadoraDcp : Dcp
{
    public required string Parametro {get; set;}

    public LavadoraDcp(string code, int inputPerTurn, bool start, bool mid, bool end) : base(code, inputPerTurn, start, mid, end)
    {
    }

}