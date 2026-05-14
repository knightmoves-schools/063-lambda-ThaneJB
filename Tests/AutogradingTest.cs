namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Remove_The_Formatter_Class_And_Replace_The_Format_Method_With_An_Equivalent_Lambda_Expression(){
       var label = new Label();
       var result = label.LabelFormatter("prefix", "value");
       Assert.Equal("prefix - value", result);

       var formattedResult = label.FormatAddress("test");
       Assert.Equal("US - test", formattedResult);
    }
}