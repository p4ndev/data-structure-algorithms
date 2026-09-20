/// <summary>
/// Organize data from two sorted list into a single list sorted too
/// </summary>
public class MergeTwoSortedLists : ProblemAbstraction<IList<int>, IList<int>, IList<int>>, ProblemContract
{
    protected override void Review()
    {
        Console.ForegroundColor = Expected.SequenceEqual(Output) ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine("[{0}]", string.Join(",", Output));
    }

    public void Initialize()
    {
        // 1. Normal (tamanhos diferentes + valores intercalados)
        Expected = [-12, -10, -8, -4, 0, 2, 3, 6, 8, 9];
        Output = Run(
            [-12, -8, 3, 6, 9],
            [-10, -4, 0, 2, 8]
        );
        Review();

        // 2. Duplicados entre as duas listas
        Expected = [1, 1, 2, 2, 3, 3];
        Output = Run(
            [1, 2, 3],
            [1, 2, 3]
        );
        Review();

        // 3. Uma lista vazia
        Expected = [1, 2, 3, 4];
        Output = Run(
            [],
            [1, 2, 3, 4]
        );
        Review();

        // 4. As duas listas vazias
        Expected = [];
        Output = Run(
            [],
            []
        );
        Review();

        // 5. Um elemento em cada lista
        Expected = [-5, 10];
        Output = Run(
            [10],
            [-5]
        );
        Review();

        // 6. Listas grandes + valores intercalados
        Expected = [-20, -19, -17, -15, -14, -12, -10, -9, -7, -5, -4, -2, 0, 1, 3, 4, 6, 8, 11, 13, 15, 18, 20];
        Output = Run(
            [-20, -17, -14, -12, -9, -7, -4, -2, 1, 4, 6, 11, 15, 20],
            [-19, -15, -10, -5, 0, 3, 8, 13, 18]
        );
        Review();
    }

    private IList<int> Run(IList<int> n0, IList<int> n1)
    {
        if (n0.Count == 0 && n1.Count == 0)     return new List<int>();
        if (n1.Count == 0)                      return n0;
        if (n0.Count == 0)                      return n1;

        int i = 0, j = 0, z = 0;
        int m = Math.Max(n0.Count, n1.Count);
        var o = new int[n0.Count + n1.Count];

        while (i < m)
        {
            if ((i < n0.Count) && (j < n1.Count))
            {
                if (n0[i] < n1[j])  o[z++] = n0[i++];
                else                o[z++] = n1[j++];

                continue;
            }

            break;
        }

        if (j >= n1.Count)
        {
            while(i < n0.Count)
                o[z++] = n0[i++];
        }
        else if (i >= n0.Count)
        {
            while (j < n1.Count)
                o[z++] = n1[j++];
        }

        return o;
    }
}