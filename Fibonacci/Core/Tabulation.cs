using Fibonacci.Builder;

namespace Fibonacci.Core;

internal class Tabulation : IFib{

    private int?[] _lookup = new int?[10];

    public Tabulation(){
        _lookup[0] = 0;
        _lookup[1] = 1;
    }

    public int ElementAt(int n){

        if (!IsValid(n)) throw new ArgumentException("Our sequence end up at max 10 elements.");

        for (int i = 2; i <= n; i++)
            if (!_lookup[i].HasValue)
                _lookup[i] = _lookup[i - 1] + _lookup[i - 2];

        return _lookup[n]!.Value;

    }

    public bool IsValid(int n) => (n >= 0 && n <= 9);

}
