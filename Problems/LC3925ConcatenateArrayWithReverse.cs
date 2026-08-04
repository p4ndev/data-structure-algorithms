namespace Problems;

public class LC3925
{
    public int[] ConcatWithReverse(int[] nums)
    {
        var ans = new int[nums.Length * 2];
        int j = 0, n = 0;

        while(n < nums.Length)
        {
            j = ((ans.Length - 1) - n);
            ans[n] = ans[j] = nums[n];
            n++;
        }

        return ans;
    }
}
