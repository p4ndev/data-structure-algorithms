namespace HackerRank;

public static class SumMinMaxSlidingWindow{

    public static (int Min, int Max)? Find(int[] arr, int blockSize) {

        if (arr.Length.Equals(0) || arr.Length < blockSize)
            return null;

        int t;
        int? min = null, max = null;

        for (int i = 0; i <= (arr.Length - blockSize); i++) {

            t = arr[i];
            for (int j = 1; j < blockSize; j++)
                t += arr[i + j];

            min = Evaluate(min, t, true);
            max = Evaluate(max, t, false);

        }

        return ((min.HasValue && max.HasValue) ? (min.Value, max.Value) : null);

    }

    private static bool EvaluateMin(int reference, int current) => current < reference;

    private static bool EvaluateMax(int reference, int current) => current > reference;

    private static int Evaluate(int? reference, int current, bool minOperation) {
        
        if (
            !reference.HasValue ||
            (
                minOperation ? 
                    EvaluateMin(reference.Value, current) :
                    EvaluateMax(reference.Value, current)
            )
        ) return current;

        return reference.Value;

    }

}