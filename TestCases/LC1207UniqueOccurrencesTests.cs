namespace LC1207;

public class UniqueOccurrencesTests
{
    private readonly Problems.LC1207 _sut;

    public UniqueOccurrencesTests()
        => _sut = new(); // Arrange

    [Theory]
    [InlineData(new int[] { 1, 2 }, false)]
    [InlineData(new int[] { 1, 2, 2, 1, 1, 3 }, true)]
    [InlineData(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }, true)]
    public void Should_Be_Or_Not(int[] i, bool e)
    {
        // Act
        var r = _sut.UniqueOccurrences(i);

        // Assert
        Assert.Equal(r, e);
    }
}
