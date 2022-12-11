namespace Recursion;

internal static class AddUpTo{

    public static int Iterative(byte n) {

        int output = 0;

        for (byte i = 0; i <= n; i++)
            output += i;

        return output;

    }

    public static int Recursive(int n){

        if (n <= 0) return 0;

        return Recursive(n - 1) + n;

    }

    public static int Math(int n) {

        return (n * (n + 1)) / 2;

    }

}