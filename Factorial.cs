namespace Recursion;

internal static class Factorial {

    public static int Iterative(byte n) {

        int output = 0;

        for (int i = 0; i <= n; i++)
            output += i;

        return (output / 2);

    }

    public static int Recursive(int n) {

        if (n.Equals(1)) return 1;

        return 1 + Recursive(n - 1);

    }

    public static int Math(int n) {

        return ((2 * n) - n);

    }

}