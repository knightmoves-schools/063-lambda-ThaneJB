namespace knightmoves;

public class Label{

    public Func<string, string, string> LabelFormatter = (prefix, value) => $"{prefix} - {value}";
    public Func<string, string> FormatAddress => address => $"{"US"} - {address}";

    
}


