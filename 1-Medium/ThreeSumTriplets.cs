namespace Medium;

/// <summary>
/// Given a sorted array, return all possible unique
/// triplets where the three numbers add up is equal to zero.
/// </summary>
public class ThreeSumTriplets : IProblem{

    public void EntryPoint(){

        int[] input = { -4, -1, -1, 0, 1, 2 };

        IList<int[]> output = DivideAndConquer(input);

        foreach (var triplet in output)
            Console.WriteLine(String.Join(",", triplet));

        /*[
            [-1, -1,  2]
            [ 0, -1,  1]
            [ 1, -1,  0]
            [ 2, -1, -1]
        ]*/

    }

    private IList<int[]> DivideAndConquer(int[] input){
                
        int target;
        List<int[]> output = new();
        (int, int)? twoSum = null;

        for (int i = 0; i < input.Length; i++) {

            if (i > 0 && input[i].Equals(input[i - 1]))
                continue;

            target = (0 - input[i]);
            twoSum = TwoPointers(input, target, i);

            if (twoSum is not null) {
                output.Add(new [] {
                    input[i],
                    input[twoSum.Value.Item1],
                    input[twoSum.Value.Item2]
                });
            }
              
        }

        return output;

    }

    private (int, int)? TwoPointers(int[] input, int target, int skip){

        (int, int)? output = null;
        int t, i = 0, j = (input.Length - 1);

        while (i < j) {

            if (i.Equals(skip)) {
                i++;
                continue;
            }

            if (j.Equals(skip)){
                j--;
                continue;
            }

            t = (input[i] + input[j]);

            if (t.Equals(target)){
                output = (i, j);
                break;
            }else if (t > target)
                j--;
            else
                i++;

        }
        
        return output;

    }

}