public class MaxSumExtraSpaceLinq
{
    public static int Extract(int[] a, int k)
    {
        // Sum of the current subarray
        int i = 0, t = 0;

        // Stores all distinct subarray sums in sorted order
        SortedSet<int> xs = new();

        // Try every possible starting index for a subarray of size k
        for (i = 0; i <= (a.Length - k); i++)
        {
            // Skip i elements, take the next k elements, and calculate their sum
            t = a.Skip(i).Take(k).Sum();

            // Add the sum only if it is not already present
            if (!xs.Contains(t))
                xs.Add(t); // Automatically keeps the values sorted
        }

        // Return the largest sum stored in the set
        return xs.LastOrDefault(-1); // -1 if the set is empty
    }
}
