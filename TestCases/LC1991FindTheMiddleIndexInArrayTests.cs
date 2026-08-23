namespace LC1991;

public class LC1991FindTheMiddleIndexInArrayTests
{
    private readonly Problems.LC1991 _sut;

    public LC1991FindTheMiddleIndexInArrayTests()
        => _sut = new();

    [Theory]
    [InlineData(new[] { 2, 3, -1, 8, 4 }, 3)]
    [InlineData(new[] { 1, -1, 4 }, 2)]
    [InlineData(new[] { 2, 5 }, -1)]
    [InlineData(new[] { 1 }, 0)]
    [InlineData(new[] { 0, 0 }, 0)]
    [InlineData(new[] { 0, 1, -1 }, 0)]
    [InlineData(new[] { -1, 1, 0 }, 2)]
    public void Should_Return_Middle_Index(int[] nums, int expected)
    {
        // Act
        var result = _sut.FindMiddleIndex(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}