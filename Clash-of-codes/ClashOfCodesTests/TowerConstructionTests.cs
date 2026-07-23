namespace Tests;

public partial class ClashOfCodeTests
{
    [Theory]
    [InlineData(29, 4, 7, 5)]
    [InlineData(12, 3, 5, 4)]
    [InlineData(9, 24, 4, 0)]
    [InlineData(97, 8, 13, 9)]
    [InlineData(10, 3, 4, 3)]
    public void Construct_A_Tower(int h, int p, int q, int e)
        => Assert.Equal(_sut.TowerConstruction(h, p, q), e);
}
