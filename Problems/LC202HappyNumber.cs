namespace Problems;

public class LC202
{
    // Runtime 0ms          Beats 100   %
    // Memory  30.84 Mb     Beats 83.48 %
    public bool IsHappyFastSlowPointers(int n)
    {
        int slow = n, fast = n;

        do {
            slow = SquareSum(slow);
            fast = SquareSum(SquareSum(fast));
        } while (slow != fast);

        return (slow == 1);
    }

    private int SquareSum(int n)
    {
        int s = 0;

        while (n > 0)
        {
            int d = (n % 10);
            s += (d * d);
            n /= 10;
        }

        return s;
    }

    // Runtime 3ms          Beats 53.83 %
    // Memory  31.54 Mb     Beats 47.94 %
    public bool IsHappyNaiveExtraSpace(int n)
    {
        HashSet<int> s = new();
        int r, t;

        while (n != 1) {
            t = 0;

            while (n > 0) {
                r = (n % 10);
                n /= 10;
                t += (r * r);
            }

            if (s.Contains(t))
                return false;

            s.Add(t);
            n = t;
        }

        return true;
    }
}