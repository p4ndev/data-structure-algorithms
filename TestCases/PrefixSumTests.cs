namespace PrefixSum;

public class Scenarios
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 3, 6 })]
    [InlineData(new[] { 1, -1, 5, 3 }, new[] { 1, 0, 5, 8 })]
    [InlineData(new[] { 1, -5, 5, -1 }, new[] { 1, -4, 1, 0 })]
    public void Calculation(int[] n, int[] e)
    {
        // Act
        var result = Problems.PrefixSum.Calculate(n);

        // Assert
        Assert.Equal(e, result);
    }

    [Theory]
    [InlineData(new[] { 3, 4, -2, 5, -1, 2, 6 }, 7, 3)]
    [InlineData(new[] { 1, -1, 2, 1, -1 }, 2, 3)]
    [InlineData(new[] { 2, 1, 3, 2, 5, 1 }, 5, 2)]
    public void Total_With_Sum_K(int[] n, int k, int e)
    {
        // Act
        var result = Problems.PrefixSum.SubArraysWithSum(n, k);

        // Assert
        Assert.Equal(e, result);
    }

    [Theory]
    [InlineData(new[] { 2, 3, 1, 4, 2 }, 5, 4)]
    [InlineData(new[] { 1, 4, 2, 3 }, 5, 3)]
    [InlineData(new[] { 2, 3, 5 }, 5, 3)]
    public void Total_Divisible_By_K(int[] n, int k, int e)
    {
        // Act
        var result = Problems.PrefixSum.SubArraysDivisibleBy(n, k);

        // Assert
        Assert.Equal(e, result);
    }
}