namespace LC4;

public static class FirstApproach
{
    public static double Execute(int[] nums1, int[] nums2)
    {
        int mx = Math.Max(nums1.Length, nums2.Length);
        int acc = 0, div = 0;
        double res = 0;

        for (int i = 0; i < mx; i++)
        {
            if (nums1.Length > i) acc += nums1[i];
            if (nums2.Length > i) acc += nums2[i];
        }

        div = (nums1.Length + nums2.Length);
        res = ((double)acc / div);

        return Math.Round(res, 5);
    }
}