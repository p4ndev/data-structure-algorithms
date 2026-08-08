namespace Problems;

public class LC1207
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> d = new();
        HashSet<int> h = new();

        foreach (int n in arr)
            if (d.ContainsKey(n)) d[n]++;
            else d.Add(n, 1);

        foreach (KeyValuePair<int, int> k in d)
        {
            if (h.Contains(k.Value))
                return false;
            h.Add(k.Value);
        }

        return true;
    }
}
