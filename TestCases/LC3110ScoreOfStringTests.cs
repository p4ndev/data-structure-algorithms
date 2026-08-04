namespace LC3110;

public class ScoreOfStringTests
{
    private readonly Problems.LC3110 _sut;

    public ScoreOfStringTests()
        => _sut = new();

    [Theory]
    [InlineData("hello", 13)]
    [InlineData("zaz", 50)]
    public void Should_Extract_String_Score(string s, int e)
    {
        // Act
        var r = _sut.ScoreOfString(s);

        // Assert
        Assert.Equal(r, e);
    }
}
