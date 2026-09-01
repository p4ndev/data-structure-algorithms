namespace LC904;

public class LC904FruitIntoBasketsTests
{
    private readonly Problems.LC904 _sut;

    public LC904FruitIntoBasketsTests()
        => _sut = new();

    [Theory]
    [InlineData(new[] { 1, 2, 1 }, 3)]
    [InlineData(new[] { 0, 1, 2, 2 }, 3)]
    [InlineData(new[] { 1, 2, 3, 2, 2 }, 4)]
    [InlineData(new[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 }, 5)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 1, 1, 1, 1 }, 4)]
    [InlineData(new[] { 1, 2, 3 }, 2)]
    [InlineData(new[] { 1, 2, 1, 2 }, 4)]
    public void Should_Return_Maximum_Number_Of_Fruits(int[] fruits, int expected)
    {
        // Act
        var result = _sut.TotalFruit(fruits);

        // Assert
        Assert.Equal(expected, result);
    }
}