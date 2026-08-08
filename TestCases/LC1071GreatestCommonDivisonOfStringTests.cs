namespace LC1071;

public class GcdOfStringsTests
{
    private readonly Problems.LC1071 _sut;

    public GcdOfStringsTests()
        => _sut = new(); // Arrange

    [Theory]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("LEET", "CODE", "")]
    [InlineData("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXX")]
    public void Should_Extract_GCD_Of_Strings(string str1, string str2, string e)
    {
        // Act
        var r = _sut.GcdOfStrings(str1, str2);

        // Assert
        Assert.Equal(r, e);
    }
}
