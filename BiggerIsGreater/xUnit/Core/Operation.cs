using hacker_rank;

namespace BiggerIsGreater;

public class Operation : Stub {

    [Fact] // "abcd" swap 'b' with 'd' => "adcb"
    public void Swap(){

        var inp = PIVOT0.ToCharArray();
        var exp = new char[4] { 'a', 'd', 'c', 'b' };

        inp.Swap(1, 3);

        Assert.True(inp.SequenceEqual(exp));

    }

    [Fact] // "dcba" reverse after index 1 => "dabc"
    public void Reverse(){

        var inp = NO_PIVOT0.ToCharArray();
        var exp = new char[4] { 'd', 'a', 'b', 'c' };

        inp.Reverse(1);

        Assert.True(inp.SequenceEqual(exp));

    }

    [Fact] // "dcba" sort after index 1 => "dabc"
    public void Sort(){

        var inp = NO_PIVOT0.ToCharArray();
        var exp = new char[4] { 'd', 'a', 'b', 'c' };

        inp.Sort(1);

        Assert.True(inp.SequenceEqual(exp));

    }

    [Fact] // ['f','e','d','c','b','a','b','c','d'] merge => "fedcbabcd"
    public void Merge(){

        var inp = PIVOT6.ToCharArray();

        inp.Merge();

        Assert.Equal(PIVOT6, inp);

    }

}
