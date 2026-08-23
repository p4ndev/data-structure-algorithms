namespace Problems;

public static class PrefixSum
{
    // Range sum use os problemas disponíveis em solução (303)

    public static int[] Calculate(int[] n)
    {
        for (int i = 1; i < n.Length; i++)
            n[i] += n[i - 1];

        return n;
    }

    public static int SubArraysWithSum(int[] n, int k)
    {
        for (int i = 1; i < n.Length; i++)
            n[i] += n[i - 1];

        int c = 0;
        Dictionary<int, int> s = new() { [0] = 1 };

        foreach (int p in n)
        {
            if (s.ContainsKey(p - k))
                c += s[p - k];

            if (s.ContainsKey(p))
                s[p]++;
            else
                s.Add(p, 1);
        }

        return c;
    }

    public static int SubArraysDivisibleBy(int[] n, int k)
    {
        int c = 0, r;
        Dictionary<int, int> s = new() { [0] = 1 };

        for (int i = 1; i < n.Length; i++)
            n[i] += n[i - 1];

        foreach(int p in n)
        {
            r  = (p % k);           // passo 1: resto "cru", pode ser negativo
            if (r < 0) r += k;      // passo 2: quando necessário, corrige pro intervalo positivo [0, k-1]

            /*
            r = ( 7 % 5) .............  2 (ok, positivo)
            r = (-3 % 5) ............. -3 (errado, pois matematicamente deveria ser 2)
                                              → corrigido pelo if: -3 + 5 = 2
            */

            if (s.ContainsKey(r))
            {
                c += s[r]++;
                continue;
            }

            s.Add(r, 1);
        }

        return c;
    }
}