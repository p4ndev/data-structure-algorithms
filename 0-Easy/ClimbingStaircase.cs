namespace Easy;

/// <summary>
/// Given a staircase with n steps.
/// How many different ways we can climb by step only 1 or 2 at each step.
/// </summary>
public class ClimbingStaircase : IProblem{
    
    public void EntryPoint(){
        
        int input   = 6;
        int output  = FindUniqueWays(input);

        Console.WriteLine(
            "Staircase with {0} steps, might be climbed in {1} different ways.",
            input, output
        );

        // I/P => 2
        // O/P => 2
               // 1 + 1 ..... one way
               // 2 ......... one way

    }

    private int FindUniqueWays(int n) {
        
        if (n.Equals(1)) return 1;
        int first = 1, second = 2, third;

        for (int i = 3; i <= n; i++) {            
            third = (first + second);            
            first = second;
            second = third;
        }

        return second;

    }

}