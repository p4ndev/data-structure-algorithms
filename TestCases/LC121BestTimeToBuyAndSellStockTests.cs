namespace LC121;

public class LC121BestTimeToBuyAndSellStockTests
{
    private readonly Problems.LC121 _sut;

    public LC121BestTimeToBuyAndSellStockTests()
        => _sut = new();

    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    [InlineData(new[] { 1, 2 }, 1)]
    [InlineData(new[] { 2, 1 }, 0)]
    [InlineData(new[] { 1 }, 0)]
    [InlineData(new[] { 3, 3, 3, 3 }, 0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new[] { 5, 1, 5, 2, 8 }, 7)]
    [InlineData(new[] { 2, 4, 1 }, 2)]
    [InlineData(new[] { 3, 2, 6, 5, 0, 3 }, 4)]
    public void Should_Return_Maximum_Profit(
        int[] prices,
        int expected)
    {
        // Act
        var result = _sut.MaxProfit(prices);

        // Assert
        Assert.Equal(expected, result);
    }
}