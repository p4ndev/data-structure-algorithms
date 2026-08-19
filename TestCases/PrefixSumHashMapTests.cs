namespace PrefixSum;

public class HashMapTests
{
    [Theory]
    [InlineData(new[] { 3, 4, -2, 5, -1, 2, 6 }, 7, 3)]
    [InlineData(new[] { 1, -1, 2, 1, -1 }, 2, 3)]
    [InlineData(new[] { 2, 1, 3, 2, 5, 1 }, 5, 2)]
    public void Should_Return_Number_Of_Subarrays_With_K_Sum(int[] n, int k, int e)
    {
        // Act
        var result = Problems.PrefixSumHashMap.SubArraysWithSum(n, k);

        // Assert
        Assert.Equal(e, result);
    }
}