namespace Recursion;

internal static class Loop {

    public static string Iterative(byte n) {

        var stb = new System.Text.StringBuilder();

        for (byte i = 0; i <= n; i++) {
            stb.Append(i);
            stb.Append(" ");
        }

        return stb.ToString();

    }

    public static string Recursive(int n) {

        if (n < 0) return "";
        var stb = new System.Text.StringBuilder();

        stb.Append(Recursive(n - 1));
        stb.Append(n > 0 ? " " : "");
        stb.Append(n);

        return stb.ToString();

    }

}