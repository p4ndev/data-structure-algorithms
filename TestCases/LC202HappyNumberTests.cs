namespace LC202;

public class LC202HappyNumberTests
{
    private readonly Problems.LC202 _sut;

    public LC202HappyNumberTests()
        => _sut = new();

    [Theory]
    [InlineData(19, true)]
    [InlineData(2, false)]
    [InlineData(1, true)]
    [InlineData(7, true)]
    [InlineData(4, false)]
    public void Should_Return_Expected_Result(int n, bool expected)
    {
        // Act
        var result = _sut.IsHappy(n);

        // Assert
        Assert.Equal(expected, result);
    }
}