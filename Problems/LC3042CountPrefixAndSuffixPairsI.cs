namespace Problems;

public class LC3042
{
    public int CountPrefixSuffixPairs(string[] w)
    {
        int o = 0;

        for (int i = 0; i < (w.Length - 1); i++)
            for (int j = (i + 1); j < w.Length; j++)
                if (w[j].StartsWith(w[i]) && w[j].EndsWith(w[i]))
                    o++;

        return o;
    }
}