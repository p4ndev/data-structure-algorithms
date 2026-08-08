namespace LC345;

public class LC345ReverseVowelsTests
{
    private readonly Problems.LC345 _sut;

    public LC345ReverseVowelsTests()
        => _sut = new();

    [Theory]
    [InlineData("IceCreAm", "AceCreIm")]
    [InlineData("leetcode", "leotcede")]
    [InlineData("a", "a")]
    [InlineData("aeiou", "uoiea")]
    [InlineData("hello", "holle")]
    [InlineData("xyz", "xyz")]
    public void Should_Reverse_Vowels(string s, string expected)
    {
        // Act
        var result = _sut.ReverseVowels(s);

        // Assert
        Assert.Equal(expected, result);
    }
}