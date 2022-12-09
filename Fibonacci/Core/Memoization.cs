using Fibonacci.Builder;

namespace Fibonacci.Core;

internal class Memoization : IFib{

    private int?[] _lookup = new int?[10];

    public Memoization(){
        _lookup[0] = 0;
        _lookup[1] = 1;
    }

    public int ElementAt(int n){

        if (!IsValid(n)) throw new ArgumentException("Our sequence end up at max 10 elements.");

        if (!_lookup[n].HasValue)
            _lookup[n] = ElementAt(n - 1) + ElementAt(n - 2);

        return _lookup[n]!.Value;

    }

    public bool IsValid(int n) => (n >= 0 && n <= 9);

}
