namespace Problems;

public static class MaxConsecutiveOnes
{
    public static IEnumerable<int> Extract(int[] n)
    {
        int i = 0;

        for (int j = 0; j < n.Length; j++)
        {
            if (n[j] == 1)
            {
                (n[i], n[j]) = (n[j], n[i]);
                i++;
            }
        }

        return n.Take(i);
    }
}