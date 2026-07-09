namespace LC2073;

public class TimeRequiredToBuyTests
{
    private readonly Problems.LC2073 _sut;

    // Arrange
    public TimeRequiredToBuyTests()
        => _sut = new();

    [Theory]
    [InlineData(new int[] { }, 0, 0)]
    [InlineData(new int[] { }, -1, 0)]
    [InlineData(new int[] { 100 }, 0, 100)]
    [InlineData(new int[] { 2, 3, 2 }, 2, 6)]
    [InlineData(new int[] { 4, 4, 4 }, 1, 11)]
    [InlineData(new int[] { 1, 1, 1, 1 }, 2, 3)]
    [InlineData(new int[] { 2, 2, 2, 2 }, 3, 8)]
    [InlineData(new int[] { 5, 1, 1, 1 }, 0, 8)]
    [InlineData(new int[] { 10, 10, 10 }, 2, 30)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, 15)]
    public void Test(int[] tickets, int k, int e)
    {
        // Act
        var o = _sut.TimeRequiredToBuy(tickets, k);

        // Assert
        Assert.Equal(e, o);
    }
}
