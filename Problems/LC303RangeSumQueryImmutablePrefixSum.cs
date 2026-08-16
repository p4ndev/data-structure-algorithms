namespace Problems;

public partial class LC303
{
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