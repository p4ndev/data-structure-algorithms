namespace Problems;

public class LC974
{
    public int SubarraysDivByK(int[] nums, int k)
    {
        int[] prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
            prefixSum[i] = prefixSum[i - 1] + nums[i];

        Dictionary<int, int> remainderCount = new();
        remainderCount[0] = 1;

        int answer = 0;

        foreach (int sum in prefixSum)
        {
            int remainder = ((sum % k) + k) % k;

            if (remainderCount.ContainsKey(remainder))
                answer += remainderCount[remainder];

            remainderCount[remainder] = remainderCount.GetValueOrDefault(remainder) + 1;
        }

        return answer;
    }
}