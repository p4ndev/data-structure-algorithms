namespace Problems;

public class LC26
{
    public int RemoveDuplicatesExtraSpace(int[] nums) {
        HashSet<int> s = new();

        foreach (int n in nums)
        {
            if (s.Contains(n))
                continue;
            s.Add(n);
        }

        int i = 0;

        foreach (int n in s)
            nums[i++] = n;

        return s.Count;
    }

    public int RemoveDuplicatesInPlace(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        int k = 1;

        for(int i = 1; i < nums.Length; i++)
            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }

        return k;        
    }
}