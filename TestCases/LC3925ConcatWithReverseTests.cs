namespace LC3925;

public class ConcatWithReverseTests
{
    private readonly Problems.LC3925 _sut;

    public ConcatWithReverseTests()
        => _sut = new();

    [Fact]
    public void Should_Return_Six_Positions()
    {
        // Arrange
        var num = new int[] { 1, 2, 3 };
        var exp = new int[] { 1, 2, 3, 3, 2, 1 };

        // Act
        var res = _sut.ConcatWithReverse(num);

        // Assert
        Assert.Equal(exp, res);
    }

    [Fact]
    public void Should_Return_Single_Position()
    {
        // Arrange
        var num = new int[] { 1 };
        var exp = new int[] { 1, 1 };

        // Act
        var res = _sut.ConcatWithReverse(num);

        // Assert
        Assert.Equal(exp, res);
    }
}
