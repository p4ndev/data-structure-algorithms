namespace Problems;

public class LC4
{
    /*
    40ms Runtime	5,15 % Beats			58Mb Memory	5,39% Beats
    https://leetcode.com/problems/median-of-two-sorted-arrays/submissions/2042517707 
    */
    public double FindMedianSortedArrays_Mine(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0 && nums2.Length == 0)
            return 0;

        bool isTotalEven = false;
        int middle = -1, sum = 0;
        LinkedListNode<int>? current;
        double output = 0, median = 0;
        int[] arr = new int[nums1.Length + nums2.Length];
        bool isFirstLarger = (nums1.Length > nums2.Length);
        int[] remainingItems = (isFirstLarger ? nums2 : nums1);
        LinkedList<int> merged = new(isFirstLarger ? nums1 : nums2);

        foreach (int item in remainingItems)
        {
            current = merged.First;
            while (current is not null)
            {
                if (item < current.Value)
                {
                    if (current.Previous is null || current.Previous.Value > item)
                    {
                        merged.AddBefore(current, item);
                        break;
                    }
                }
                else if (item == current.Value)
                {
                    merged.AddBefore(current, item);
                    break;
                }
                else if (item > current.Value)
                {
                    if (current.Next is null || current.Next.Value > item)
                    {
                        merged.AddAfter(current, item);
                        break;
                    }
                }

                current = current.Next;
            }
        }

        isTotalEven = (merged.Count % 2 == 0);
        middle = (merged.Count / 2);
        arr = merged.ToArray();

        if (isTotalEven)
        {
            sum = (arr[middle - 1] + arr[middle]);
            median = ((double)sum / 2);
            output = Math.Round(median, 5);
        }
        else
            output = (double)arr[middle];

        return output;
    }

    public double FindMedianSortedArrays_Best(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays_Best(nums2, nums1);

        int m = nums1.Length;
        int n = nums2.Length;
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
                if ((m + n) % 2 == 0)
                    return (Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2.0;
                else
                    return Math.Max(maxLeftX, maxLeftY);
            else if (maxLeftX > minRightY)
                right = partitionX - 1;
            else
                left = partitionX + 1;
        }

        throw new ArgumentException("Input arrays are not sorted");
    }
}
