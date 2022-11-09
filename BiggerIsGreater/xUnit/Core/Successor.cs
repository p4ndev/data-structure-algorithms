using static hacker_rank.AlgorithmImplementation;

namespace BiggerIsGreater;

public class Successor : Stub {

    [Theory]
    [InlineData(PIVOT0, 'c', 3)] // "abcd" found 'c' at index 3
    [InlineData(PIVOT1, 'm', 2)] // "lmno" found 'm' at index 2
    [InlineData(PIVOT2, 'a', 1)] // "abdc" found 'a' at index 1
    [InlineData(PIVOT2, 'b', 3)] // "abdc" found 'b' at index 3
    public void FindIndex(string input, char letter, int expected) {
        var sut = FindSuccessor(input.ToCharArray(), letter);
        Assert.Equal(sut, expected);
    }

    [Fact] // "adcb" found 'c' at index 1 (previously)
    public void WhenBefore() {
        var sut = FindSuccessor("adcb".ToCharArray(), 'c');
        Assert.True(sut!.Value.Equals(1));
    }

    [Fact] // "cccc" didn't find 'c' at any index
    public void NotFound() {
        var sut = FindSuccessor(NO_PIVOT2.ToCharArray(), 'c');
        Assert.Null(sut);
    }

}