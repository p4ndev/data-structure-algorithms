namespace Easy;

public class Reverse32BitInteger : IProblem{
    
    public void EntryPoint(){
        
        int input    = 321;
        int expected = 123;

        var output0 = MathOnlySplitted(input);
        var output1 = MathOnlySimplest(input);

        Display.Out(output0, output0.Equals(expected));
        Display.Out(output1, output1.Equals(expected));

    }

    private int MathOnlySplitted(int num) {

        Func<bool> IsDecimal = () => (num >= -9 && 9 >= num);
        if (IsDecimal()) return num;

        int tmp = 0, rev = 0;
        while (!IsDecimal()) {
            tmp  = num % 10;
            rev  = (10 * rev) + tmp;
            num /= 10;
        }
        rev = (10 * rev) + num;
        
        return rev;

    }

    private int MathOnlySimplest(int num) {

        long output = 0;

        while(num != 0){
            output = (output * 10) + (num % 10);
            num /= 10;
        }

        if (output > int.MaxValue || output < int.MinValue) return 0;

        return (int)output;

    }

}
