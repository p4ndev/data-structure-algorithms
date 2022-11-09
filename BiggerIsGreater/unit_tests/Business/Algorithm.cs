using hacker_rank;

namespace BiggerIsGreater;

public class Algorithm : Stub {

    [Theory]
    [InlineData(NO_PIVOT0)]     // "dcba"   => no answer
    [InlineData(NO_PIVOT1)]     // "bb"     => no answer
    [InlineData(NO_PIVOT3)]     // "ba"     => no answer
    [InlineData(NO_PIVOT4)]     // "dcbb"   => no answer
    public void Empty(string w){
        var sut = AlgorithmImplementation.BiggerIsGreater(w);
        Assert.Equal(EMPTY, sut);
    }

    [Theory]
    [InlineData(PIVOT1,     "lmon")]        // "lmno"       => will be "lmon"
    [InlineData(PIVOT4,     "abdc")]        // "abcd"       => will be "abdc"
    [InlineData(PIVOT5,     "dhkc")]        // "dhck"       => will be "dhkc"
    [InlineData(NO_PIVOT5,  "hcdk")]        // "dkhc"       => will be "hcdk"
    [InlineData(PIVOT6,     "fedcbabdc")]   // "fedcbabcd"  => will be "fedcbabdc"
    public void SwapLast2Letters(string w, string e){
        var sut = AlgorithmImplementation.BiggerIsGreater(w);
        Assert.Equal(e, sut);
    }

}