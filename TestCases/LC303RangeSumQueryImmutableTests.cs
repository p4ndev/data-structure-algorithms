namespace LC303;

public class LC303RangeSumQueryImmutableTests
{
    [Fact]
    public void Should_Return_Sum_For_Range()
    {
        // Arrange
        var nums = new[] { -2, 0, 3, -5, 2, -1 };
        var sut0 = new Problems.LC303.NumArray(nums);
        var sut1 = new Problems.LC303.NumArrayPrefixSum(nums);

        // Act
        var result0 = sut0.SumRange(0, 2);
        var result1 = sut1.SumRange(0, 2);

        // Assert
        Assert.Equal(1, result0);
        Assert.Equal(1, result1);
    }

    [Fact]
    public void Should_Return_Sum_For_Different_Ranges()
    {
        // Arrange
        var nums = new[] { -2, 0, 3, -5, 2, -1 };
        var sut0 = new Problems.LC303.NumArray(nums);
        var sut1 = new Problems.LC303.NumArrayPrefixSum(nums);

        // Act
        var result0A = sut0.SumRange(0, 2);
        var result1B = sut0.SumRange(2, 5);
        var result2C = sut0.SumRange(0, 5);

        var result0D = sut1.SumRange(0, 2);
        var result1E = sut1.SumRange(2, 5);
        var result2F = sut1.SumRange(0, 5);

        // Assert
        Assert.Equal(1, result0A);
        Assert.Equal(-1, result1B);
        Assert.Equal(-3, result2C);

        Assert.Equal(1, result0D);
        Assert.Equal(-1, result1E);
        Assert.Equal(-3, result2F);
    }

    [Fact]
    public void Should_Return_Single_Value_When_Left_Equals_Right()
    {
        // Arrange
        var nums = new[] { -2, 0, 3, -5, 2, -1 };
        var sut0 = new Problems.LC303.NumArray(nums);
        var sut1 = new Problems.LC303.NumArrayPrefixSum(nums);

        // Act
        var result0 = sut0.SumRange(2, 2);
        var result1 = sut1.SumRange(2, 2);

        // Assert
        Assert.Equal(3, result0);
        Assert.Equal(3, result1);
    }

    [Fact]
    public void Should_Return_Entire_Array_Sum()
    {
        // Arrange
        var nums = new[] { 1, 2, 3, 4, 5 };
        var sut0 = new Problems.LC303.NumArray(nums);
        var sut1 = new Problems.LC303.NumArrayPrefixSum(nums);

        // Act
        var result0 = sut0.SumRange(0, 4);
        var result1 = sut1.SumRange(0, 4);

        // Assert
        Assert.Equal(15, result0);
        Assert.Equal(15, result1);
    }
}