public static class Equilibrium
{
    public static int Find(int[] arr)
    {
        int n = arr.Length;
        int[] pref = new int[n];
        int[] suff = new int[n];

        pref[0] = arr[0];
        suff[n - 1] = arr[n - 1];

        for (int i = 1; i < n; i++)
            pref[i] = pref[i - 1] + arr[i];

        for (int i = n - 2; i >= 0; i--)
            suff[i] = suff[i + 1] + arr[i];

        for (int i = 0; i < n; i++)
            if (pref[i] == suff[i])
                return i;

        return -1;
    }
}