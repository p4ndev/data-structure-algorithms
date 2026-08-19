namespace LC974;

public class LC974SubarraySumsDivisibleByKTests
{
    private readonly Problems.LC974 _sut;

    public LC974SubarraySumsDivisibleByKTests()
        => _sut = new();

    [Theory]
    [InlineData(new[] { 4, 5, 0, -2, -3, 1 }, 5, 7)]
    [InlineData(new[] { 5 }, 9, 0)]
    [InlineData(new[] { 1 }, 1, 1)]
    [InlineData(new[] { 0 }, 2, 1)]
    [InlineData(new[] { 0, 0 }, 2, 3)]
    [InlineData(new[] { 2, 4, 6 }, 2, 6)]
    public void Should_Return_Number_Of_Subarrays_Divisible_By_K(int[] nums, int k, int expected)
    {
        // Act
        var result = _sut.SubarraysDivByK(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }
}