int[] presum = new int[] { 45, 57, 63, 78, 89, 97 };
int[] original = new int[] { 45, 12, 6, 15, 11, 8 };

int[] arr = DecodeArray(presum);

Console.WriteLine(string.Join(",", presum));
Console.WriteLine(string.Join(",", original));

static int[] DecodeArray(int[] presum)
{
    int i = (presum.Length - 1), o;

    while(i >= 0)
    {
        if (i == 0) break;

        o = presum[i - 1];
        presum[i] -= o;
        i--;
    }

    return presum;
}
