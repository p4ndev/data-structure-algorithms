/// <summary>
/// Find three elements where the sum is equal a target
/// </summary>
public class ThreeSum : ProblemAbstraction<int[], int[], int[]>, ProblemContract
{
    public int Target { get; set; }

    protected override void Review()
    {
        Console.ForegroundColor = Expected.SequenceEqual(Output) ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine("{0} = {1}", string.Join(" + ", Output), Target);
    }

    public void Initialize()
    {
        // 1. Basic case
        Target = 8;
        Expected = [-2, 4, 6];
        Input = [-5, -2, 3, 4, 6];
        Output = Run(Input, Target);
        Review();

        // 2. Negative target
        Target = -8;
        Expected = [-6, -4, 2];
        Input = [-10, -6, -4, 2, 5, 9];
        Output = Run(Input, Target);
        Review();

        // 3. All negative numbers
        Target = -9;
        Expected = [-5, -4, 0];
        Input = [-8, -5, -4, 0, 2];
        Output = Run(Input, Target);
        Review();

        // 4. All positive numbers
        Target = 15;
        Expected = [1, 2, 12];
        Input = [1, 2, 6, 8, 9, 12];
        Output = Run(Input, Target);
        Review();

        // 5. Zeros
        Target = 0;
        Expected = [0, 0, 0];
        Input = [0, 0, 0, 0, 0];
        Output = Run(Input, Target);
        Review();

        // 6. Negative + zero + positive
        Target = 0;
        Expected = [-5, -2, 7];
        Input = [-5, -2, 0, 3, 4, 7];
        Output = Run(Input, Target);
        Review();

        // 7. Duplicates
        Target = 6;
        Expected = [2, 2, 2];
        Input = [1, 2, 2, 2, 4, 7];
        Output = Run(Input, Target);
        Review();

        // 8. Duplicate values but different combination
        Target = 5;
        Expected = [-1, 2, 4];
        Input = [-1, -1, 0, 2, 4, 5];
        Output = Run(Input, Target);
        Review();

        // 9. Minimum valid input length
        Target = 6;
        Expected = [1, 2, 3];
        Input = [1, 2, 3];
        Output = Run(Input, Target);
        Review();

        // 10. Minimum input length without solution
        Target = 7;
        Expected = [];
        Input = [1, 2, 3];
        Output = Run(Input, Target);
        Review();

        // 11. Less than 3 elements
        Target = 3;
        Expected = [];
        Input = [1, 2];
        Output = Run(Input, Target);
        Review();

        // 12. Empty input
        Target = 0;
        Expected = [];
        Input = [];
        Output = Run(Input, Target);
        Review();

        // 13. Multiple possible combinations
        Target = 6;
        Expected = [-2, 1, 7];
        Input = [-5, -2, 0, 1, 3, 5, 7];
        Output = Run(Input, Target);
        Review();

        // 14. Solution uses first element
        Target = 0;
        Expected = [-10, 3, 7];
        Input = [-10, -5, 0, 3, 7, 20];
        Output = Run(Input, Target);
        Review();

        // 15. Solution uses last element
        Target = 10;
        Expected = [0, 1, 9];
        Input = [-5, -1, 0, 1, 4, 9];
        Output = Run(Input, Target);
        Review();

        // 16. No solution (target too small)
        Target = -100;
        Expected = [];
        Input = [-10, -5, -2, 0, 4];
        Output = Run(Input, Target);
        Review();

        // 17. No solution (target too large)
        Target = 100;
        Expected = [];
        Input = [-10, -5, -2, 0, 4];
        Output = Run(Input, Target);
        Review();

        // 18. Large negative / positive range
        Target = 0;
        Expected = [-1000000, 1, 999999];
        Input = [-1000000, -500, 1, 100, 999999, 2000000];
        Output = Run(Input, Target);
        Review();
    }

    private int[] Run(int[] n, int k)
    {
        if (n.Length <= 2)
            return [];

        for (int f = 0; f < (n.Length - 2); f++)
        {
            int l = (f + 1),
                r = (n.Length - 1);

            while (l < r)
            {
                int t = (n[f] + n[l] + n[r]);

                if (t == k)
                    return [n[f], n[l], n[r]];

                if (t < k) l++;
                else r--;
            }
        }

        return [];
    }
}