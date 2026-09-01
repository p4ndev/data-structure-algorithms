namespace LC1652;

public class LC1652DefuseTheBombTests
{
    private readonly Problems.LC1652 _sut;

    public LC1652DefuseTheBombTests()
        => _sut = new();

    [Theory]
    [InlineData(new[] { 1 }, 0, new[] { 0 })]
    [InlineData(new[] { 1, 2, 3, 4 }, 0, new[] { 0, 0, 0, 0 })]
    [InlineData(new[] { 1, 2, 3, 4 }, 1, new[] { 2, 3, 4, 1 })]
    [InlineData(new[] { 1, 2, 3, 4 }, -1, new[] { 4, 1, 2, 3 })]
    [InlineData(new[] { 2, 4, 9, 3 }, -2, new[] { 12, 5, 6, 13 })]
    [InlineData(new[] { 5, 7, 1, 4 }, 3, new[] { 12, 10, 16, 13 })]
    [InlineData(new[] { 5, 5, 5, 5 }, 2, new[] { 10, 10, 10, 10 })]
    public void Should_Decrypt_Code(int[] c, int k, int[] e)
    {
        // Act
        var r = _sut.Decrypt(c, k);

        // Assert
        Assert.Equal(e, r);
    }
}