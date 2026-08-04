namespace LC3838;

public class MapWordWeightsTests
{
    private readonly Problems.LC3838 _sut;

    public MapWordWeightsTests()
        => _sut = new();

    [Fact]
    public void Should_Return_RIJ_Lowercase()
    {
        // Arrange
        var wo = new string[] { "abcd", "def", "xyz" };
        var we = new int[] { 5, 3, 12, 14, 1, 2, 3, 2, 10, 6, 6, 9, 7, 8, 7, 10, 8, 9, 6, 9, 9, 8, 3, 7, 7, 2 };

        // Act
        var result = _sut.MapWordWeights(wo, we);

        // Assert
        Assert.Equal("rij", result);
    }

    [Fact]
    public void Should_Return_YYY_Lowercase()
    {
        // Arrange
        var wo = new string[] { "a", "b", "c" };
        var we = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        // Act
        var result = _sut.MapWordWeights(wo, we);

        // Assert
        Assert.Equal("yyy", result);
    }

    [Fact]
    public void Should_Return_G_Lowercase()
    {
        // Arrange
        var wo = new string[] { "abcd" };
        var we = new int[] { 7, 5, 3, 4, 3, 5, 4, 9, 4, 2, 2, 7, 10, 2, 5, 10, 6, 1, 2, 2, 4, 1, 3, 4, 4, 5 };

        // Act
        var result = _sut.MapWordWeights(wo, we);

        // Assert
        Assert.Equal("g", result);
    }
}
