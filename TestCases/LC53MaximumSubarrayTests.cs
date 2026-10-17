namespace LC53;

public class LC53MaximumSubarrayTests
{
    private readonly Problems.LC53 _sut;

    public LC53MaximumSubarrayTests()
        => _sut = new(); // Arrange

    [Theory]
    [InlineData(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 5, 4, -1, 7, 8 }, 23)]
    [InlineData(new[] { -1, -2, -3, -4 }, -1)]
    [InlineData(new[] { 1, 2, 3, 4 }, 10)]
    [InlineData(new[] { -2, 1 }, 1)]
    [InlineData(new[] { 0, 0, 0 }, 0)]
    [InlineData(new[] { -2, -1 }, -1)]
    [InlineData(new[] { 8, -8, 8 }, 8)]
    [InlineData(new[] { -2, -3, 4, -1, -2, 1, 5, -3 }, 7)]
    public void Should_Return_Maximum_Subarray_Sum(int[] n, int e)
    {
        // Act
        var r = _sut.MaxSubArray(n);

        // Assert
        Assert.Equal(e, r);
    }
}