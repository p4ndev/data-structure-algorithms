namespace LC4;

public static class BestApproach
{
    public static double Execute(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
            return Execute(nums2, nums1);

        int m = nums1.Length, n = nums2.Length;
        int totalLeft = (m + n + 1) / 2;
        int left = 0, right = m;

        while (left <= right)
        {
            int partitionX = (left + right) / 2;
            int partitionY = totalLeft - partitionX;

            int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
            int minRightX = (partitionX == m) ? int.MaxValue : nums1[partitionX];

            int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
            int minRightY = (partitionY == n) ? int.MaxValue : nums2[partitionY];

            if (maxLeftX <= minRightY && maxLeftY <= minRightX)
            {
                if ((m + n) % 2 == 0)
                    return (Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2.0;
                else
                    return Math.Max(maxLeftX, maxLeftY);
            }
            else if (maxLeftX > minRightY)
                right = (partitionX - 1);
            else
                left = (partitionX + 1);
        }

        return 0;
    }
}

/*
 var nums1 = new int[] { 2, 2, 4, 4 };
var nums2 = new int[] { 2, 2, 2, 4, 4 };
var exp = 2.0;

//var nums1 = new int[] { 1, 3 };
//var nums2 = new int[] { 2 };
//var exp = 2.0;

//var nums1 = new int[] { 1, 2 };
//var nums2 = new int[] { 3, 4 };
//var exp = 2.5;

var res = LC4.BestApproach.Execute(nums1, nums2);

Console.WriteLine(res);
Console.WriteLine(exp);
Console.ReadKey();
 */