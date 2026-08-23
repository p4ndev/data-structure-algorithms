namespace Problems;

public class LC1991
{
    public int FindMiddleIndex(int[] nums)
    {
        int total = 0;
        foreach (int n in nums)
            total += n;

        int leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int rightSum = (total - leftSum - nums[i]);

            if (leftSum == rightSum)
                return i;

            leftSum += nums[i];
        }

        return -1;
    }
}