namespace Problems;

public partial class LC303
{
    // 15:22        No pattern applied
    // 91ms         Runtime         23.11 % Beats
    // 65.30Mb      Memory          85.06 % Beats
    // https://leetcode.com/problems/range-sum-query-immutable/submissions/2108959128

    public class NumArray
    {
        private readonly int[] _n;

        public NumArray(int[] nums)
        {
            _n = nums;
        }

        public int SumRange(int left, int right)
        {
            int acc = 0;

            while(left < right)
            {
                acc += _n[left] + _n[right];
                left++;         right--;
            }

            if (left == right)
                acc += _n[left];

            return acc;
        }
    }
}