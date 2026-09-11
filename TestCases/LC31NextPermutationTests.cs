namespace LC31;

public class LC31NextPermutationTests
{
    private readonly Problems.LC31 _sut;

    public LC31NextPermutationTests()
        => _sut = new();

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 3, 2 })]
    [InlineData(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 1, 5 }, new[] { 1, 5, 1 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 1, 2 }, new[] { 2, 1 })]
    [InlineData(new[] { 2, 1 }, new[] { 1, 2 })]
    [InlineData(new[] { 1, 3, 2 }, new[] { 2, 1, 3 })]
    [InlineData(new[] { 2, 3, 1 }, new[] { 3, 1, 2 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 4, 3 })]
    [InlineData(new[] { 1, 3, 2, 4 }, new[] { 1, 3, 4, 2 })]
    [InlineData(new[] { 1, 5, 1 }, new[] { 5, 1, 1 })]
    public void Should_Return_Next_Permutation(int[] n, int[] e)
    {
        // Act
        _sut.NextPermutation(n);

        // Assert
        Assert.Equal(e, n);
    }
}