namespace LC560;

public class LC560SubarraySumEqualsKTests
{
    private readonly Problems.LC560 _sut;

    public LC560SubarraySumEqualsKTests()
        => _sut = new();

    [Theory]
    [InlineData(new[] { 1, 1, 1 }, 2, 2)]
    [InlineData(new[] { 1, 2, 3 }, 3, 2)]
    [InlineData(new[] { 1, -1, 0 }, 0, 3)]
    [InlineData(new[] { 1 }, 1, 1)]
    [InlineData(new[] { 1 }, 0, 0)]
    [InlineData(new[] { 0, 0, 0 }, 0, 6)]
    [InlineData(new[] { -1, -1, 1 }, -1, 3)]
    [InlineData(new[] { 2, -1, 1, 2 }, 2, 4)]
    public void Should_Return_Number_Of_Subarrays_With_Sum(int[] nums, int k, int expected)
    {
        // Act
        var result = _sut.SubarraySum(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }
}