namespace Recursion;

internal static class ReverseArray{

    public static void Iterative(ref int[] arr) {

        if (arr.Length <= 1) return;
        
        for (int i = 0, j = (arr.Length - 1); i < j; i++, j--)
            Swap(ref arr, i, j);

    }

    public static void Recursive(ref int[] arr, int? left = null, int? right = null) {

        if (arr.Length <= 1) return;

        if (!left.HasValue && !right.HasValue) {
            left = 0;
            right = (arr.Length - 1);
        }

        if (left!.Value >= right!.Value) return;

        Swap(ref arr, left!.Value, right!.Value, true);

    }

    private static void Swap(ref int[] arr, in int left, in int right, bool isRecursive = false) {

        int t       = arr[left];
        arr[left]   = arr[right];
        arr[right]  = t;

        if(isRecursive)
            Recursive(ref arr, (left + 1), (right - 1));

    }

}