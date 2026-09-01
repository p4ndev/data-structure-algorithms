namespace Problems;

public class LC904
{
    public int TotalFruit(int[] f)
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
}