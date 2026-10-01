namespace LC3042;

public class LC3042CountPrefixAndSuffixPairsITests
{
    // Arrange
    private readonly Problems.LC3042 _sut = new();

    [Theory]
    [InlineData(new[] { "a", "aba", "ababa", "aa" }, 4)]
    [InlineData(new[] { "pa", "papa", "ma", "mama" }, 2)]
    [InlineData(new[] { "abab", "ab" }, 0)]
    [InlineData(new[] { "a", "a" }, 1)]
    [InlineData(new[] { "a", "a", "a" }, 3)]
    [InlineData(new[] { "ab", "ab", "ab" }, 3)]
    [InlineData(new[] { "a", "ab", "abc" }, 0)]
    [InlineData(new[] { "aa", "aaaa", "aaaaaa" }, 3)]
    [InlineData(new[] { "abc", "abcabc", "abcabcabc" }, 3)]
    [InlineData(new[] { "x" }, 0)]
    public void Should_Count_Prefix_And_Suffix_Pairs(string[] w, int e)
    {
        // Act
        var result = _sut.CountPrefixSuffixPairs(w);

        // Assert
        Assert.Equal(e, result);
    }
}