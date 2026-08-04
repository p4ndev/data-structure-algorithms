namespace LC3945;

public class DigitFrequencyScoreTests
{
    private readonly Problems.LC3945 _sut;

    public DigitFrequencyScoreTests()
        => _sut = new();

    [Theory]
    [InlineData(122, 5)]
    [InlineData(101, 2)]
    public void Should_Extract_Frequency_Score(int n, int e)
    {
        // Act
        var r = _sut.DigitFrequencyScore(n);

        // Assert
        Assert.Equal(r, e);
    }
}
