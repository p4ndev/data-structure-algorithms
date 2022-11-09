using static hacker_rank.AlgorithmImplementation;

namespace BiggerIsGreater;

public class Pivot : Stub {

    [Fact] // "abcd" found => index 2 ^ not null
    public void Found() {
        var sut = FindPivot(PIVOT0.ToCharArray());
        Assert.NotNull(sut);
        Assert.Equal(2, sut!.Value);
    }

    [Theory]
    [InlineData(NO_PIVOT0)] // "dcba"
    [InlineData(NO_PIVOT1)] // "bb"
    [InlineData(NO_PIVOT2)] // "cccc"
    [InlineData(NO_PIVOT3)] // "ba"
    public void NotFound(string w) => Assert.Null(FindPivot(w.ToCharArray()));

    [Theory]
    [InlineData(PIVOT0, 'c', 2)]    // "abcd" => 'c' eq index 2
    [InlineData(PIVOT2, 'b', 1)]    // "abdc" => 'b' eq index 1
    [InlineData(PIVOT3, 'a', 0)]    // "ab"   => 'a' eq index 0
    public void PivotAt(string input, char character, int expected){

        var idx = FindPivot(input.ToCharArray());

        var sut = idx!.Value.Equals(expected);

        Assert.Equal(input[expected], character);

        Assert.True(sut);

    }

}