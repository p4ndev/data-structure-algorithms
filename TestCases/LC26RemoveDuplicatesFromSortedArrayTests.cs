namespace LC26;

public class LC26RemoveDuplicatesFromSortedArrayTests
{
    private readonly Problems.LC26 _sut;

    public LC26RemoveDuplicatesFromSortedArrayTests()
        => _sut = new();

    [Fact]
    public void Should_Remove_Duplicates_From_Example_One()
    {
        // Arrange
        var nums = new[] { 1, 1, 2 };

        // Act
        int result = _sut.RemoveDuplicatesInPlace(nums);

        // Assert
        Assert.Equal(2, result);
        Assert.Equal(new[] { 1, 2 }, nums[..result]);
    }

    [Fact]
    public void Should_Remove_Duplicates_From_Example_Two()
    {
        // Arrange
        var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        // Act
        var result = _sut.RemoveDuplicatesInPlace(nums);

        // Assert
        Assert.Equal(5, result);
        Assert.Equal(new[] { 0, 1, 2, 3, 4 }, nums[..result]);
    }

    [Fact]
    public void Should_Return_One_When_Array_Has_One_Element()
    {
        // Arrange
        var nums = new[] { 1 };

        // Act
        var result = _sut.RemoveDuplicatesInPlace(nums);

        // Assert
        Assert.Equal(1, result);
        Assert.Equal(new[] { 1 }, nums[..result]);
    }

    [Fact]
    public void Should_Return_One_When_All_Elements_Are_Duplicates()
    {
        // Arrange
        var nums = new[] { 2, 2, 2, 2 };

        // Act
        var result = _sut.RemoveDuplicatesInPlace(nums);

        // Assert
        Assert.Equal(1, result);
        Assert.Equal(new[] { 2 }, nums[..result]);
    }

    [Fact]
    public void Should_Return_All_Elements_When_There_Are_No_Duplicates()
    {
        // Arrange
        var nums = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = _sut.RemoveDuplicatesInPlace(nums);

        // Assert
        Assert.Equal(5, result);
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, nums[..result]);
    }
}