namespace Problems;

public class LC3945
{
    private readonly Dictionary<int, int> f;

    public LC3945()
        => f = new();

    private void IncrementOrInitialize(int n)
    {
        if (f.ContainsKey(n))   f[n]++;
        else                    f.Add(n, 1);
    }

    public int DigitFrequencyScore(int n)
    {
        int d = 0, r = 0, o = 0;

        while(n >= 10)
        {
            d = (n / 10);
            r = (n % 10);
            n = d;

            IncrementOrInitialize(r);
        }

        IncrementOrInitialize(n);

        foreach (KeyValuePair<int, int> k in f)
            o += (k.Key * k.Value);

        return o;
    }
}
