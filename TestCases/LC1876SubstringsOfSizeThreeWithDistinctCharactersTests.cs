namespace LC1876;

public class LC1876SubstringsOfSizeThreeWithDistinctCharactersTests
{
    private readonly Problems.LC1876 _sut;

    public LC1876SubstringsOfSizeThreeWithDistinctCharactersTests()
        => _sut = new();

    [Theory]
    [InlineData("abc", 1)]
    [InlineData("xyy", 0)]
    [InlineData("xxx", 0)]
    [InlineData("xxy", 0)]
    [InlineData("xxxabc", 1)]
    [InlineData("xyzzaz", 1)]
    [InlineData("aababcabc", 4)]
    [InlineData("aaa", 0)]
    [InlineData("a", 0)]
    [InlineData("ab", 0)]
    [InlineData("abcd", 2)]
    [InlineData("abcabc", 4)]
    public void Should_Return_Number_Of_Good_Substrings(string s, int expected)
    {
        // Act
        var result = _sut.CountGoodSubstrings(s);

        // Assert
        Assert.Equal(expected, result);
    }
}