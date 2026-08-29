public static class MaxSumNaive
{
    public static int Extract(int[] a, int k)
    {
        // Maximum sum found so far
        int ms = int.MinValue,

            // Start index of the current subarray
            i = 0,

            // Offset used to access each element inside the current subarray
            j = 0,

            // Sum of the current subarray
            cs = 0,

            // Number of possible subarrays of size k
            tb = (a.Length - k + 1);

        // Try every possible starting position for a subarray of size k
        for (i = 0; i < tb; i++)
        {
            // Reset the current sum before calculating the next subarray
            cs = 0;

            // Calculate the sum of the k elements starting at index i
            for (j = 0; j < k; j++)
                cs += a[i + j];

            // Keep the largest sum found so far
            ms = Math.Max(cs, ms);
        }

        // Return the maximum sum among all subarrays of size k
        return ms;
    }
}