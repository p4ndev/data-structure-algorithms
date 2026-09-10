namespace Problems;

public class LC904
{
    public int TotalFruitOnTwoBaskets(int[] f)
    {
        int l = 0, m = 0, c = 0, k = 2;
        Dictionary<int, int> s = new();

        for (int r = 0; r < f.Length; r++)
        {
            if (!s.ContainsKey(f[r]))
                s[f[r]] = 0;

            s[f[r]]++;

            while (s.Count > k)
            {
                s[f[l]]--;

                if (s[f[l]] == 0)
                    s.Remove(f[l]);

                l++;
            }

            c = (r - l + 1);
            m = Math.Max(m, c);
        }

        return m;
    }

    public int MaxDistinctedFruitsOnTwoBaskets(char[] f) {
        int t, k = 2, i = 0, j = 0, m = 0, n = f.Length;
        Dictionary<char, int> s = new();

        if (n < k)
            return n;

        while (j < n)
        {
            char r = f[j];

            s[r] = s.GetValueOrDefault(r) + 1;

            while (s.Count > k)
            {
                char l = f[i++];
                s[l]--;

                if (s[l] == 0)
                    s.Remove(l);
            }

            t = ((j - i) + 1);
            m = Math.Max(m, t);

            j++;
        }

        return m;
    }
}