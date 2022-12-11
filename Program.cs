using Recursion;

byte    input0 = 3;
int[]   input1 = { 10, 20, 30, 40, 50, 60 };

Console.WriteLine(Loop.Iterative(input0));
Console.WriteLine(Loop.Recursive(input0));

Console.WriteLine();

Console.WriteLine(Factorial.Iterative(input0));
Console.WriteLine(Factorial.Recursive(input0));
Console.WriteLine(Factorial.Math(input0));

Console.WriteLine();

Console.WriteLine(AddUpTo.Iterative(input0));
Console.WriteLine(AddUpTo.Recursive(input0));
Console.WriteLine(AddUpTo.Math(input0));

Console.WriteLine();

Console.WriteLine(String.Join(" ", input1));
ReverseArray.Iterative(ref input1);
Console.WriteLine(String.Join(" ", input1));
ReverseArray.Recursive(ref input1);
Console.WriteLine(String.Join(" ", input1));