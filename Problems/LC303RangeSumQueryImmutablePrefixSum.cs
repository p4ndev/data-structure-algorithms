namespace Problems;

public partial class LC303
{
    // 00:00        Prefix Sum + Math
    // 0ms          Runtime         100 % Beats
    // 0Mb          Memory          100 % Beats
    // https://leetcode.com/problems/range-sum-query-immutable/submissions/2117295124

    public class NumArrayPrefixSum
    {
        private readonly int[] _n;

        public NumArrayPrefixSum(int[] n)
        {
            for (int i = 1; i < n.Length; i++)
                n[i] = n[i - 1] + n[i];
            _n = n;
        }

        public int SumRange(int l, int r)
        {
            int a = _n[r];

            if (l != 0)
                a -= _n[l - 1];

            return a;
        }
    }
}