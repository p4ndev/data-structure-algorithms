namespace LC152;

public class LC152MaximumProductSubarrayTests
{
    private readonly Problems.LC152 _sut;

    public LC152MaximumProductSubarrayTests()
        => _sut = new(); // Arrange

    [Theory]
    [InlineData(new[] { 2, 3, -2, 4 }, 6)]
    [InlineData(new[] { -2, 0, -1 }, 0)]
    [InlineData(new[] { -2, 3, -4 }, 24)]
    [InlineData(new[] { 0, 2 }, 2)]
    [InlineData(new[] { -2 }, -2)]
    [InlineData(new[] { -2, -3, -4 }, 12)]
    [InlineData(new[] { 2, -5, -2, -4, 3 }, 24)]
    [InlineData(new[] { 1, 2, 3, 4 }, 24)]
    [InlineData(new[] { -1, -2, 0, -3, -4 }, 12)]
    [InlineData(new[] { 0, 0, 0 }, 0)]
    public void Should_Return_Maximum_Product(int[] n, int e)
    {
        // Act
        var r = _sut.MaxProduct(n);

        // Assert
        Assert.Equal(e, r);
    }
}