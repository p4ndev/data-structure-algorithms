/// <summary>
/// Check if the target sum is available within a sorted numbers
/// </summary>
public class TargetSum : ProblemAbstraction<int[], bool, bool>, ProblemContract
{
    public void Initialize()
    {
        Expected = false;
        Input = [-6, -4, 3, 8, 12];
        Output = Run(Input, 58);
        Review();

        Expected = true;
        Input = [-6, -4, 3, 8, 12];
        Output = Run(Input, 4);
        Review();

        Expected = false;
        Input = [-4, 0, 3, 8, 12];
        Output = Run(Input, 2);
        Review();

        Expected = true;
        Input = [-6, -4, 3, 8, 12];
        Output = Run(Input, -10);
        Review();

        Expected = false;
        Input = [];
        Output = Run(Input, 0);
        Review();
    }

    private bool Run(int[] n, int k)
    {
        int t, i = 0, j = (n.Length - 1);

        while(i < j)
        {
            t = (n[i] + n[j]);

            if (t == k)
                return true;

            if (t < k)  i++;
            else        j--;
        }

        return false;
    }
}