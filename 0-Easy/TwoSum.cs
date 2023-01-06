using System.Collections;

namespace Easy;

public class TwoSum : IProblem{
    
    public void EntryPoint(){
        
        var target   = 50;
        var input    = new[] { -8, 4, 7, 10, 43 };
        var expected = new Tuple<int, int>(2, 4);

        var output0  = Unsorted(input, target);
        if (output0 is null)
            Display.Out("Not found", false);
        else {
            Display.Out(output0.Item1, expected.Item1);
            Display.Out(output0.Item2, expected.Item2);
        }

        var output1 = SortedAsc(input, target);
        if (output1 is null)
            Display.Out("Not found", false);
        else{
            Display.Out(output1.Item1, expected.Item1);
            Display.Out(output1.Item2, expected.Item2);
        }

    }

    private Tuple<int, int>? Unsorted(int[] arr, int target) {

        var ht = new Hashtable();

        for (int i = 0; i < arr.Length; i++) {
            
            if (ht.ContainsKey(arr[i]))
                return new Tuple<int, int>((int)ht[arr[i]]!, i);
            
            var tmp = target - arr[i];
            ht.Add(tmp, i);

        }

        return null;

    }

    private Tuple<int, int>? SortedAsc(int[] arr, int target) {

        int left = 0, right = (arr.Length - 1), tmp = 0;

        if (right < 0) return null;

        while (left < right) {
            
            tmp = arr[left] + arr[right];            
            
            if (tmp.Equals(target))
                return new Tuple<int, int>(left, right);
            
            if (tmp > target)
                right--;
            else
                left++;
        }

        return null;

    }

}
