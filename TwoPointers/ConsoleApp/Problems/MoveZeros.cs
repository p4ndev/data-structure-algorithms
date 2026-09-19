/// <summary>
/// Move all zeros to the left (partition around a condition)
/// </summary>
public class MoveZeros : ProblemAbstraction<int[], int[], int[]>, ProblemContract
{
    protected override void Review()
    {
        Console.ForegroundColor = (
            Expected.SequenceEqual(Output) ? ConsoleColor.Green : ConsoleColor.Red
        );

        Console.WriteLine(
            "E/P : [{0}]\nO/P : [{1}]\n------------------------------",
            string.Join(",", Expected),
            string.Join(",", Output)
        );
    }

    public void Initialize()
    {
        Input       = [0, 1, 1, 1, 0, 1, 0, 1, 0, 0];
        Expected    = [0, 0, 0, 0, 0, 1, 1, 1, 1, 1];
        Output      = Run(Input);
        Review();

        Input       = [0, 0, 0, 0, 0, 0];
        Expected    = [0, 0, 0, 0, 0, 0];
        Output      = Run(Input);
        Review();

        Input       = [1, 1, 1, 1, 1, 0];
        Expected    = [0, 1, 1, 1, 1, 1];
        Output      = Run(Input);
        Review();

        Input       = [1, 1, 1, 1, 1, 1];
        Expected    = [1, 1, 1, 1, 1, 1];
        Output      = Run(Input);
        Review();

        Input       = [1, 1, 1, 0, 0, 0];
        Expected    = [0, 0, 0, 1, 1, 1];
        Output      = Run(Input);
        Review();

        Input       = [1, 0, 0, 0, 0, 0];
        Expected    = [0, 0, 0, 0, 0, 1];
        Output      = Run(Input);
        Review();

        Input       = [1, 0];
        Expected    = [0, 1];
        Output      = Run(Input);
        Review();

        Input       = [0];
        Expected    = [0];
        Output      = Run(Input);
        Review();

        Input       = [1];
        Expected    = [1];
        Output      = Run(Input);
        Review();
    }

    private int[] Run(int[] n)
    {
        if (n.Length <= 1)
            return n;

        int i = 0, j = (n.Length - 1);

        while (i < j) {

            if (n[i] == 0 && (n[j] == 0 || n[j] == 1)) {
                i++;
                continue;
            }

            if (n[i] == 1) {                
                if(n[j] == 1) { 
                    j--;
                    continue;
                }

                (n[i], n[j]) = (n[j], n[i]);
            }
                        
            i++;            j--;

        }

        return n;
    }
}