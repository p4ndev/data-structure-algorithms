public class MaxPairs : IPairs {
    public int[] Find(int[] input, int k, int p){
        int[] pairs = new int[p];
        for (int i = 0; i <= (p - 1); i++) {
            var max = input[i];
            for (int j = 1; j < k; j++) {
                if (input[i + j] > max)
                    max = input[i + j];
            }
            pairs[i] = max;
        }
        return pairs;
    }
}