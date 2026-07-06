string input = "1-(     -2)";
int output = Calculate(input), expectation = 3;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "1+(-2)";
output = Calculate(input); expectation = -1;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "0-(-1)";
output = Calculate(input); expectation = 1;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "-(1-(2+3))";
output = Calculate(input); expectation = 4;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "-(2+3)";
output = Calculate(input); expectation = -5;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "(-2+3)";
output = Calculate(input); expectation = 1;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "(-2-3)";
output = Calculate(input); expectation = -5;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "-2147483647";
output = Calculate(input); expectation = -2147483647;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "(-123)";
output = Calculate(input); expectation = -123;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "1 + 1";
output = Calculate(input); expectation = 2;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "(1+(4+5+2)-3)+(6+8)";
output = Calculate(input); expectation = 23;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = " 2-1 + 2 ";
output = Calculate(input); expectation = 3;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = " 2-1 + 2 - 5 + 20 - 5 ";
output = Calculate(input); expectation = 13;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "(1+(4+5+2)-3)+(6+8)";
output = Calculate(input); expectation = 23;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "(1+(4+5+2)-3)+(6+8)";
output = Calculate(input); expectation = 23;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

input = "-2147483648";
output = Calculate(input); expectation = -2147483648;

Console.ForegroundColor = expectation.Equals(output) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.White;

/***********************************************************************************************************************/
/***********************************************************************************************************************/
/***********************************************************************************************************************/

// Time     : 5 hours
// Runtime  : 49 ms         Beats   : 6.67%
// Memory   : 54.78 Mb      Beats   : 8.33%
// https://leetcode.com/problems/basic-calculator/submissions/2058302278

/***********************************************************************************************************************/
/***********************************************************************************************************************/
/***********************************************************************************************************************/

void PersistPendingData(Stack<string> storage, System.Text.StringBuilder sb) {
    if (sb.Length <= 0)
        return;

    storage.Push(sb.ToString());
    sb.Clear();
}

void SolveOperations(Stack<string> storage, Stack<long> numbers)
{
    Stack<bool> sumOperations = new();
    long num = 0, acc = 0, tmp = 0;
    numbers.Clear();
    string term;

    #pragma warning disable CS8600
    while (storage.TryPop(out term) && !term.Equals(")"))
    {
        switch (term)
        {
            case "+":
                sumOperations.Push(true);
                break;

            case "-":
                sumOperations.Push(false);
                break;

            default:
                num = Convert.ToInt64(term);
                
                if (sumOperations.Count > 0 && !sumOperations.Pop())
                    num *= -1;

                numbers.Push(num);
                break;
        }
    }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

    while (numbers.TryPop(out tmp))
        acc += tmp;

    storage.Push(acc.ToString());
}

int Calculate(string s)
{
    if (String.IsNullOrWhiteSpace(s))
        return default;

    System.Text.StringBuilder sb = new();
    Stack<string> storage = new();
    Stack<long> numbers = new();
    char input;

    for (int i = (s.Length - 1); i >= 0; i--)
    {
        input = s[i];

        switch(input)
        {
            case var c when Char.IsWhiteSpace(c):
                PersistPendingData(storage, sb);
                break;

            case var d when Char.IsDigit(d):
                sb.Insert(0, input);
                break;

            case ')':
            case '+':
            case '-':
                PersistPendingData(storage, sb);
                storage.Push(input.ToString());
                break;

            case '(':
                PersistPendingData(storage, sb);
                SolveOperations(storage, numbers);
                break;
        }
    }

    PersistPendingData(storage, sb);

    if (storage.Count > 1)
        SolveOperations(storage, numbers);

    return Convert.ToInt32(storage.Pop());
}