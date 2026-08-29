public class MaxSumNaiveLinq
{
    public static int Extract(int[] a, int k)
    {
        // Current starting index of the subarray
        int i = 0,

            // Sum of the current subarray
            t = 0,

            // Maximum sum found so far
            ms = int.MinValue;

        // Try every possible starting index for a subarray of size k
        for (i = 0; i <= (a.Length - k); i++)
        {
            // Skip i elements, take the next k elements, and calculate their sum
            t = a.Skip(i).Take(k).Sum();

            // Keep the largest sum found so far
            ms = Math.Max(t, ms);
        }

        // Return the maximum sum found
        return ms;
    }
}