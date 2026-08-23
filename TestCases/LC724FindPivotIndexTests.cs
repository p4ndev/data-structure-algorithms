namespace LC724;

public class LC724FindPivotIndexTests
{
    private readonly Problems.LC724 _sut;

    public LC724FindPivotIndexTests()
        => _sut = new();

    [Theory]
    [InlineData(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [InlineData(new[] { 1, 2, 3 }, -1)]
    [InlineData(new[] { 2, 1, -1 }, 0)]
    [InlineData(new[] { 0, 0, 0, 0 }, 0)]
    [InlineData(new[] { 1 }, 0)]
    [InlineData(new[] { -1, -1, -1, 0, 1, 1 }, 0)]
    public void Should_Return_Pivot_Index(int[] nums, int expected)
    {
        // Act
        var result = _sut.PivotIndex(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}