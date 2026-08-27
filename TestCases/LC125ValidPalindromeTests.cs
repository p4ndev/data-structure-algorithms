namespace LC125;

public class LC125ValidPalindromeTests
{
    private readonly Problems.LC125.ExtraIteration _sut0;
    private readonly Problems.LC125.SingleIteration _sut1;

    public LC125ValidPalindromeTests()
    {
        _sut0 = new();
        _sut1 = new();
    }

    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    [InlineData("a", true)]
    [InlineData("ab", false)]
    [InlineData("0P", false)]
    [InlineData(".,", true)]
    [InlineData("Madam", true)]
    [InlineData("12321", true)]
    [InlineData("12345", false)]
    public void Should_Return_Expected_Result_Extra_Iteration(string s, bool expected)
    {
        // Act
        var result = _sut0.IsPalindrome(s);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    [InlineData("a", true)]
    [InlineData("ab", false)]
    [InlineData("0P", false)]
    [InlineData(".,", true)]
    [InlineData("Madam", true)]
    [InlineData("12321", true)]
    [InlineData("12345", false)]
    public void Should_Return_Expected_Result_Single_Iteration(string s, bool expected)
    {
        // Act
        var result = _sut1.IsPalindrome(s);

        // Assert
        Assert.Equal(expected, result);
    }
}