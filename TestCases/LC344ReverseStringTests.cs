namespace LC344;

public class LC344ReverseStringTests
{
    private readonly Problems.LC344 _sut;

    public LC344ReverseStringTests()
        => _sut = new();

    [Theory]
    [InlineData(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
    [InlineData(new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    [InlineData(new[] { 'a' }, new[] { 'a' })]
    [InlineData(new[] { 'a', 'b' }, new[] { 'b', 'a' })]
    [InlineData(new[] { '1', '2', '3', '4' }, new[] { '4', '3', '2', '1' })]
    public void Should_Reverse_String_In_Place(char[] s, char[] expected)
    {
        // Act
        _sut.ReverseString(s);

        // Assert
        Assert.Equal(expected, s);
    }
}