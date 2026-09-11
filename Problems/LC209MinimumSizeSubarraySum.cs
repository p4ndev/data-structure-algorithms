namespace Problems;

public class LC209
{
    public int MinSubArrayLen(int k, int[] a)
    {
        int c, i = 0, m = int.MaxValue, t = 0;

        for (int j = 0; j < a.Length; j++)
        {
            t += a[j];

            while (t >= k)
            {
                c = ((j - i) + 1);
                m = Math.Min(m, c);
                t -= a[i++];
            }
        }

        return (m == int.MaxValue ? 0 : m);
    }
}
