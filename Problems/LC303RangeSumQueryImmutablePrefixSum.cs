namespace Problems;

public partial class LC303
{
    public class NumArrayPrefixSum
    {
        private readonly int[] prefArr;

        public NumArrayPrefixSum(int[] nums)
        {
            prefArr = new int[nums.Length + 1];

            for (var i = 0; i < nums.Length; i++)
                prefArr[i + 1] = prefArr[i] + nums[i];
        }

        public int SumRange(int left, int right)
        {
            return prefArr[right + 1] - prefArr[left];
        }
    }
}