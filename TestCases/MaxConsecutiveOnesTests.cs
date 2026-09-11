namespace MaxConsecutiveOnesTests;

public class Scenarios
{
    [Theory]
    [InlineData(
        new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 },
        new[] { 1, 1, 1, 1, 1, 1, 1 }
    )]
    [InlineData(
        new[] { 0, 0, 0, 0 },
        new int[] { }
    )]
    [InlineData(
        new[] { 1, 1, 1, 1 },
        new[] { 1, 1, 1, 1 }
    )]
    [InlineData(
        new[] { 0, 1, 0, 1, 0, 1 },
        new[] { 1, 1, 1 }
    )]
    [InlineData(
        new[] { 1, 0, 1, 0, 1, 0, 1 },
        new[] { 1, 1, 1, 1 }
    )]
    [InlineData(
        new[] { 0, 1, 1, 1, 0, 0 },
        new[] { 1, 1, 1 }
    )]
    [InlineData(
        new[] { 0, 0, 1, 1, 1, 1 },
        new[] { 1, 1, 1, 1 }
    )]
    [InlineData(
        new[] { 1, 1, 0, 0, 0, 1 },
        new[] { 1, 1, 1 }
    )]
    [InlineData(
        new[] { 0, 1, 0, 0, 1, 0, 0, 1 },
        new[] { 1, 1, 1 }
    )]
    [InlineData(
        new[] { 1, 0, 0, 0, 0, 0, 1 },
        new[] { 1, 1 }
    )]
    public void Check(int[] n, IEnumerable<int> e)
    {
        // Act
        IEnumerable<int> r = Problems.MaxConsecutiveOnes.Extract(n);

        // Assert
        Assert.Equal(e, r);
    }
}
