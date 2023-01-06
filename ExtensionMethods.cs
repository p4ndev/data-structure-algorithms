using static System.Console;

public static class Display{

    public static void Out(object input) => WriteLine(input);

    public static void Out(int input, int expected) {
        ForegroundColor = input.Equals(expected) ? ConsoleColor.Green : ConsoleColor.Red;
        WriteLine(input);
        ResetConsole();
    }

    public static void Out(object input, bool assertion) {
        ForegroundColor = input.Equals(assertion) ? ConsoleColor.Green : ConsoleColor.Red;
        WriteLine(input);
        ResetConsole();
    }

    private static void ResetConsole() => ForegroundColor = ConsoleColor.White;
}