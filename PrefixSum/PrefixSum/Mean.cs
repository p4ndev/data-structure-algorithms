public static class Mean
{
    public static List<int> Find(int[] arr, int[][] queries)
    {
        // Prefix sum instead of a native approach
        List<int> output = new();

        // Possible side effect
        if (arr.Length == 0 || queries.Length == 0)
            return output;

        for (int i = 1; i < arr.Length; i++)
            arr[i] += arr[i - 1];

        int l, r, e, c;
        foreach (int[] q in queries)
        {
            l = q[0];
            r = q[1];

            e = ((r + 1) - l);
            
            c = arr[r];
            if (l != 0)
                c -= arr[l - 1];

            c /= e;

            output.Add(c);
        }

        return output;
    }

    /*
    var output = new List<int>();

    int t, o, l, r;
    foreach (int[] q in queries)
    {
        t = o = 0;
        l = q[0];
        r = q[1];

        while(l <= r)
        {
            t += arr[l++];
            o++;
        }

        output.Add(t / o);
    }

    return output; 
    */
}