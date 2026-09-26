namespace LC128;

public class LC128LongestConsecutiveSequenceTests
{
    private readonly Problems.LC128 _sut;

    public LC128LongestConsecutiveSequenceTests()
        => _sut = new();

    [Theory]
    [InlineData(new[] { 100, 4, 200, 1, 3, 2 }, 4)]
    [InlineData(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
    [InlineData(new[] { 1, 0, 1, 2 }, 3)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new int [] { }, 0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 5)]
    [InlineData(new[] { 5, 4, 3, 2, 1 }, 5)]
    [InlineData(new[] { 1, 1, 1, 1 }, 1)]
    [InlineData(new[] { 1, 3, 5, 7 }, 1)]
    [InlineData(new[] { -3, -2, -1, 0, 1 }, 5)]
    public void Should_Return_Longest_Consecutive_Sequence(int[] nums, int expected)
    {
        // Act
        var result = _sut.LongestConsecutive(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}