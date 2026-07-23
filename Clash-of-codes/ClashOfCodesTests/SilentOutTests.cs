using Problems;

namespace Tests;

public partial class ClashOfCodeTests
{
    private readonly ClashOfCodeCore _sut = new();

    [Fact]
    public void Silent_Out_Four_Front_Words()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        var counter = 4;
        var input = "HEAD SHOULDERS KNEES TOES";
        var expectation =
                $"_ SHOULDERS KNEES TOES{Environment.NewLine}" +
                $"_ _ KNEES TOES{Environment.NewLine}" +
                $"_ _ _ TOES{Environment.NewLine}" +
                $"_ _ _ _{Environment.NewLine}";

        // Act
        _sut.SilentOut(input, counter, DataType.WORD, Direction.FRONT);
        
        // Assert
        Assert.Equal(output.ToString(), expectation);
    }

    [Fact]
    public void Silent_Out_German_Back_Letters()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        var counter = 5;
        var input = "WANZE";
        var expectation =
                $"W A N Z _{Environment.NewLine}" +
                $"W A N _ _{Environment.NewLine}" +
                $"W A _ _ _{Environment.NewLine}" +
                $"W _ _ _ _{Environment.NewLine}" +
                $"_ _ _ _ _{Environment.NewLine}";

        // Act
        _sut.SilentOut(input, counter, DataType.LETTER, Direction.BACK);

        // Assert
        Assert.Equal(output.ToString(), expectation);
    }
}
