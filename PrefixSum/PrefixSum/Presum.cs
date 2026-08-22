public static class Presum
{
    public static int[] DecodeArray(int[] presum)
    {
        int i = (presum.Length - 1), o;

        while (i >= 0)
        {
            if (i == 0) break;

            o = presum[i - 1];
            presum[i] -= o;
            i--;
        }

        return presum;
    }
}