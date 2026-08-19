namespace Problems;

public static class PrefixSumHashMap
{
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
}