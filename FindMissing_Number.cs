var arr = new int[]{ 1,2,4,5,6 };  // Ouput: 3

Console.WriteLine(
    FindMissing_Number_Efficient(arr, arr.Length)
);

static int FindMissing_Number_Efficient(int[] a, int n) {
    Array.Sort(a);
    for (int i = 0, t = 0; i < (n - 1); i++){
        t = (a[i] + 1);
        if (t != a[i + 1]) return t;
    }
    return Int32.MaxValue;
}