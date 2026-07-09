namespace Problems;

public static class LC1
{
    private static int[]? Check(int p0, int p1, int target, int[] nums)
    {
        if (target.Equals(nums[p0] + nums[p1]))
            return [p0, p1];
        return null;
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        int[] output = [];

        switch (nums.Length)
        {
            case 0:
            case 1:
                return output;

            case 2:
                var tmp = Check(0, 1, target, nums);

                if (tmp is not null)
                    return tmp;

                return output;
        }

        int left = 0, right = (nums.Length - 1), sum = 0;

        do
        {
            var tmp = Check(left, right, target, nums);

            if (tmp is not null) return tmp;

            sum = (nums[left] + nums[right]);

            if (sum > target)   right--;
            else                left++;

        } while (left < right);

        return output;
    }
}
