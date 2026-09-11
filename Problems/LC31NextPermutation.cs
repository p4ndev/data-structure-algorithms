namespace Problems;

public class LC31
{
    public void NextPermutation(int[] nums)
    {
        int j, t, n = nums.Length, i = (n - 2);

        while (i >= 0 && nums[i] >= nums[i + 1])
            i--;

        if (i >= 0)
        {
            j = (n - 1);

            while (nums[j] <= nums[i])
                j--;

            (nums[i], nums[j]) = (nums[j], nums[i]);
        }

        t = (n - i - 1);
        Array.Reverse(nums, i + 1, t);
    }
}