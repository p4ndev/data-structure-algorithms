public static class Split
{
    public static bool IsAbleTo(int[] arr)
    {
        // Don't store the prefix causing O(n) memory
        int total = 0;
        
        foreach (int n in arr)
            total += n;

        if ((total % 2) != 0)
            return false;

        int leftSum = 0;
        
        for(int i = 0; i < arr.Length; i++)
        {
            leftSum += arr[i];

            if (leftSum == (total - leftSum))
                return true;
        }

        return false;
    }

    /*
    int total, i;
    var prefix = new int[arr.Length];
        
    prefix[0] = arr[0];
    for (i = 1; i < arr.Length; i++)
        prefix[i] = arr[i] + prefix[i - 1];
    total = prefix[i - 1];

    if ((total % 2) != 0)
        return false;

    for (i = 0; i < arr.Length; i++)
        if (prefix[i] == (total - prefix[i]))
            return true;

    return false; 
    */
}