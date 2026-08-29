public class MaxSumSliddingWindowBest
{
    public static int Extract(int[] a, int k)
    {
        // Invalid input: there is no subarray of size k
        if (a.Length <= k)
            return -1;

        // Calculate the sum of the first window of size k
        int ms = 0, i = 0;

        for (i = 0; i < k; i++)
            ms += a[i];

        // Current window sum.
        int ws = ms;

        // Slide the window one position at a time
        for (i = k; i < a.Length; i++)
        {
            // Add the new element entering the window
            ws += a[i];

            // Subtract the element leaving the window
            ws -= a[i - k];

            // Keep the maximum window sum found so far
            ms = Math.Max(ms, ws);
        }

        // Return the maximum sum of any subarray of size k
        return ms;
    }
}
