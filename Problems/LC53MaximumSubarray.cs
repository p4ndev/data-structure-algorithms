namespace Problems;

public class LC53
{
    public int MaxSubArray(int[] n)
    {
        int c, m, t;

        c = m = n[0];

        for (int i = 1; i < n.Length; i++) {

            t = c + n[i];

            //c = Math.Max(t, n[i]);
            if (t < n[i])   c = n[i];
            else            c = t;

            // m = Math.Max(m, c);
            if (c > m) m = c;

        }

        return m;
    }
}