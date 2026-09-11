namespace LC209;

public class LC209MinimumSizeSubarraySumTests
{
    private readonly Problems.LC209 _sut;

    public LC209MinimumSizeSubarraySumTests()
        => _sut = new();

    [Theory]
    [InlineData(7, new[] { 2, 3, 1, 2, 4, 3 }, 2)]
    [InlineData(4, new[] { 1, 4, 4 }, 1)]
    [InlineData(11, new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
    [InlineData(1, new[] { 1 }, 1)]
    [InlineData(5, new[] { 5 }, 1)]
    [InlineData(6, new[] { 1, 2, 3 }, 3)]
    [InlineData(15, new[] { 5, 1, 3, 5, 10, 7, 4, 9, 2, 8 }, 2)]
    [InlineData(100, new[] { 1, 2, 3, 4, 5 }, 0)]
    public void Should_Return_Minimum_Subarray_Length(int k, int[] n, int e)
    {
        // Act
        int r = _sut.MinSubArrayLen(k, n);

        // Assert
        Assert.Equal(e, r);
    }
}