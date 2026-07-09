using System.Text;

namespace Problems;

// Time     : 5 hours
// Runtime  : 49 ms         Beats   : 6.67%
// Memory   : 54.78 Mb      Beats   : 8.33%
// https://leetcode.com/problems/basic-calculator/submissions/2058302278

public class LC224
{
    private void PersistPendingData(Stack<string> storage, StringBuilder sb)
    {
        if (sb.Length <= 0)
            return;

        storage.Push(sb.ToString());
        sb.Clear();
    }

    private void SolveOperations(Stack<string> storage, Stack<long> numbers)
    {
        Stack<bool> sumOperations = new();
        long num = 0, acc = 0, tmp = 0;
        numbers.Clear();
        string term;

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

        while (numbers.TryPop(out tmp))
            acc += tmp;

        storage.Push(acc.ToString());
    }

    public int Calculate(string s)
    {
        if (String.IsNullOrWhiteSpace(s))
            return default;

        StringBuilder sb = new();
        Stack<string> storage = new();
        Stack<long> numbers = new();
        char input;

        for (int i = (s.Length - 1); i >= 0; i--)
        {
            input = s[i];

            switch (input)
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
}
