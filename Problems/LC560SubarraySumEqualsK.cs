namespace Problems;

public class LC560
{
    public int SubarraySum(int[] nums, int k)
    {
        for (int i = 1; i < nums.Length; i++)
            nums[i] += nums[i - 1];

        Dictionary<int, int> s = new() { [0] = 1 };
        int c = 0;

        foreach (int p in nums)
        {
            if (s.ContainsKey(p - k))
                c += s[p - k];

            if (s.ContainsKey(p))
                s[p]++;
            else
                s.Add(p, 1);
        }

        return c;
    }
}