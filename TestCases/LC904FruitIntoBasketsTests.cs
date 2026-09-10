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
    public void Should_Return_Maximum_Number_Of_Fruits_I(int[] fruits, int expected)
    {
        // Act
        var result = _sut.TotalFruitOnTwoBaskets(fruits);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 'A' }, 1)]
    [InlineData(new[] { 'A', 'W' }, 2)]
    [InlineData(new[] { 'A', 'B', 'W' }, 2)]
    [InlineData(new[] { 'A', 'B', 'W', 'W' }, 3)]
    [InlineData(new[] { 'A', 'A', 'A', 'A' }, 4)]
    [InlineData(new[] { 'A', 'O', 'A', 'O', 'W' }, 4)]
    [InlineData(new[] { 'A', 'O', 'W', 'B', 'A' }, 2)]
    [InlineData(new[] { 'W', 'W', 'W', 'B', 'B', 'W' }, 6)]
    [InlineData(new[] { 'A', 'O', 'W', 'W', 'B', 'O', 'O', 'A', 'O' }, 4)]
    [InlineData(new[] { 'A', 'O', 'A', 'O', 'A', 'O', 'A', 'O', 'W' }, 8)]
    [InlineData(new[] { 'A', 'O', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W' }, 10)]
    public void Should_Return_Maximum_Number_Of_Fruits_II(char[] fruits, int expected)
    {
        /*
            A => Apple                  O => Orange
            W => Watermelon             B => Banana
        */

        // Act
        var result = _sut.MaxDistinctedFruitsOnTwoBaskets(fruits);

        // Assert
        Assert.Equal(expected, result);
    }
}