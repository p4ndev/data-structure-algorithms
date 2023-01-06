namespace Hard;

/// <summary>
/// There're two sorted arrays num1 (m = length) and num2 (n = length).
/// <para>Find the median of the two sorted arrays.</para>
/// The overall run time complexity should be <c>O(log (m + n))</c>
/// </summary>
public class MedianTwoSortedArrays : IProblem{

    private int _acc = 0, _ele = 0;

    public void EntryPoint(){
        
        var input0 = new[] { 1, 2 };
        var input1 = new[] { 3, 4 };

        var output = Calc(input0, input1);
        Display.Out(output, output.Equals(2.5));

    }

    public double Calc(int[] num1, int[] num2) {

        if (num1.Length.Equals(0) && num2.Length.Equals(0))
            return 0;

        int higher = Math.Max(num1.Length, num2.Length);

        for (int i = 0; i < higher; i++) {
            
            if (i < num1.Length) {
                _ele++;
                _acc += num1[i];
            }
            
            if (i < num2.Length) {
                _ele++;
                _acc += num2[i];
            }

        }

        // once not implemented enum double.NaN will be send
        return ((double)_acc / _ele);

    }

}
