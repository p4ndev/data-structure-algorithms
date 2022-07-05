CrossCuttings.ExecutionTimer tmr;

var PositiveAndNegative = () => {
    tmr = new();
    var inp = new List<int> { -5, -10, 0, -3, 8, 5, -1, 10, -3 };
    Console.WriteLine("Input:\n{0}\n", String.Join(",", inp));
    tmr.Run<List<int>>(PositivesAndNegatives.Arrange, inp);
    Console.WriteLine("Output:\n{0}\n", String.Join(",", inp));

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(tmr.Milliseconds());
    Console.WriteLine(" ms\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-------------------------------------------\n");
};

var OnlyPositive = () => {
    tmr = new();
    var inp = new List<int> { 2, 3, 1, 8, 3, 4, 2 };
    Console.WriteLine("Input:\n{0}\n", String.Join(",", inp));
    tmr.Run<List<int>>(Positives.Arrange, inp);
    Console.WriteLine("Output:\n{0}\n", String.Join(",", inp));

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(tmr.Milliseconds());
    Console.WriteLine(" ms\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-------------------------------------------\n");
};

var OnlyChars = () => {
    tmr = new();
    var inp = new char[] { 'g', 'u', 's', 't', 'a', 'v', 'o', '1', '@', '!', '@', '1', 's' };
    Console.WriteLine("Input:\n{0}\n", String.Join(",", inp));
    tmr.Run<char[]>(Chars.Arrange, inp);
    Console.WriteLine("Output:\n{0}\n", String.Join(",", inp));

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(tmr.Milliseconds());
    Console.WriteLine(" ms\n");
};

// ========================================================================
// ========================================================================
// ========================================================================

PositiveAndNegative();
OnlyPositive();
OnlyChars();
Console.ReadKey();