namespace Problems;

public class LC128
{
    // First try TLE due to check both sides,
    // the problem requires only only the first item to iterate next

    public int LongestConsecutive(int[] n)
    {
        if (n.Length <= 1)
            return n.Length;

        HashSet<int> hs = [.. n];
        int c, t, m = 1;

        if (hs.Count == 1)
            return m;

        foreach (int v in hs)
        {
            if (!hs.Contains(v - 1))
            {
                c = v;
                t = 1;

                while (hs.Contains(c + 1))
                {
                    c++;
                    t++;
                }

                m = Math.Max(m, t);
            }
        }

        return m;
    }
}