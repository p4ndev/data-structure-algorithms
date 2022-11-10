using static hacker_rank.AlgorithmImplementation;

namespace BiggerIsGreater;

public class Successor_v2 : Stub {

    [Theory]
    [InlineData(PIVOT0, 'c', 3)] // "abcd" found 'c' at index 3
    [InlineData(PIVOT1, 'm', 2)] // "lmno" found 'm' at index 2
    [InlineData(PIVOT2, 'b', 3)] // "abdc" found 'c' at index 3
    [InlineData(PIVOT2, 'c', 2)] // "abdc" found 'd' at index 2
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

    [Fact] // "fedcbabcd" successor of 'c' at index 8 => 'd'
    public void BigString(){
        var sut = FindSuccessor(PIVOT6.ToCharArray(), 'c');
        Assert.True(sut!.Value.Equals(8));
    }

}