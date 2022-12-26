public class MinPairs : IPairs{
    public int[] Find(int[] input, int k, int p){
        int[] pairs = new int[p];
        for (int i = 0; i <= (p - 1); i++) {
            var min = input[i];
            for (int j = 1; j < k; j++) {
                if (input[i + j] < min)
                    min = input[i + j];
            }
            pairs[i] = min;
        }
        return pairs;
    }
}