namespace knightmoves;

public class Label{

    public Formatter LabelFormatter = new Formatter();

    public string FormatAddress(string address){
        return LabelFormatter.Format("US", address);
    }
}

public class Formatter{

    public string Format(string prefix, string value){
        return $"{prefix} - {value}";
    }
}