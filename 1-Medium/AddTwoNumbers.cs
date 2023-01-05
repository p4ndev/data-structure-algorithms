namespace Medium;

/// <summary>
/// You're given 2 linked list of integers in reversed order.
/// Sum each items and return it
/// </summary>
public class AddTwoNumbers : IProblem{
    
    public void EntryPoint(){

        LinkedList<int> input0      = new(new[] { 2, 4, 3 });
        LinkedList<int> input1      = new(new[] { 5, 6, 4 });
        LinkedList<int> expected    = new(new[] { 7, 0, 8 });

        var result  = Run(input0, input1);
        bool assert = expected.SequenceEqual(result);

        Console.ForegroundColor = assert ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine(assert);
        Console.ForegroundColor = ConsoleColor.White;

    }

    private LinkedList<int> Run(LinkedList<int> left, LinkedList<int> right){

        int tmp = 0, acc = 0;
        LinkedList<int> output = new();
        int maxCount = Math.Max(left.Count, right.Count);        

        for (int i = 0; i < maxCount; i++) {

            acc += left.ElementAtOrDefault(i);
            acc += right.ElementAtOrDefault(i);

            if (acc <= 9) {
                output.AddLast(acc);
                acc = 0;
            } else {
                tmp = (acc % 10);
                output.AddLast(tmp);
                acc = 1;
            }

        }
        
        return output;

    }
}
