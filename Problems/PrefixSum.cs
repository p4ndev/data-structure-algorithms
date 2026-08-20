namespace Problems;

public static class PrefixSum
{
    public static int[] Calculate(int[] n)
    {
        for (int i = 1; i < n.Length; i++)
            n[i] += n[i - 1];

        return n;
    }

    public static int SubArraysWithSum(int[] n, int k)
    {
        int c = 0;
        HashSet<int> s = new() { 0 };

        for (int i = 1; i < n.Length; i++)
            n[i] += n[i - 1];

        foreach (int p in n)
        {
            if (s.Contains(p - k))
                c++;

            s.Add(p);
        }

        return c;
    }

    public static int SubArraysDivisibleBy(int[] n, int k)
    {
        int c = 0, r;

        Dictionary<int, int> s = new() {
            { 0, 1 }
        };

        for (int i = 1; i < n.Length; i++)
            n[i] += n[i - 1];

        foreach(int p in n)
        {
            r = (p % k);

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