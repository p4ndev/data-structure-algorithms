using Problems;

namespace LC20;

public class ValidParenthesesTests
{
    private readonly LC20ValidParentheses _sut;

    // Arrange
    public ValidParenthesesTests()
        => _sut = new();

    [Theory]
    [InlineData("[", false)]
    [InlineData("(){}[]", true)]
    [InlineData("([])", true)]
    [InlineData("([)", false)]
    [InlineData("([]{[()]}())", true)]
    [InlineData("([{[(](])", false)]
    public void Check_Mine(string s, bool e)
    {
        // Act
        var output = _sut.IsValid_Mine(s);

        // Assert
        Assert.Equal(output, e);
    }

    [Theory]
    [InlineData("[", false)]
    [InlineData("(){}[]", true)]
    [InlineData("([])", true)]
    [InlineData("([)", false)]
    [InlineData("([]{[()]}())", true)]
    [InlineData("([{[(](])", false)]
    public void Check_Best_Runtime(string s, bool e)
    {
        // Act
        var output = _sut.IsValid_Best_Runtime(s);

        // Assert
        Assert.Equal(output, e);
    }

    [Theory]
    [InlineData("[", false)]
    [InlineData("(){}[]", true)]
    [InlineData("([])", true)]
    [InlineData("([)", false)]
    [InlineData("([]{[()]}())", true)]
    [InlineData("([{[(](])", false)]
    public void Check_Best_Memory(string s, bool e)
    {
        // Act
        var output = _sut.IsValid_Best_Memory(s);

        // Assert
        Assert.Equal(output, e);
    }
}
