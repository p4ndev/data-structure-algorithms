using Fibonacci.Builder;

namespace Fibonacci.Core;

internal class Common : IFib{

    public int ElementAt(int n){
        
        if (!IsValid(n)) throw new ArgumentException("Our sequence end up at max 10 elements.");

        if (n <= 1) return n;
        
        return ElementAt(n - 1) + ElementAt(n - 2);

    }

    public bool IsValid(int n) => (n >= 0 && n <= 9);

}
