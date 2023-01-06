namespace Hard;

/// <summary>
/// There are N children standing in a line, with their ratings. You're giving candies to these children subjected to the following requirements:
/// <list type="bullet">
///    <item>Each child must have at least one candy</item>
///    <item>Children with a higher rating get more candies then their neighbors</item>
/// </list>
/// <para>What's the minimum candies you must give?</para>
/// <list type="bullet">
///    <item>I/P: [1,0,2]<para>O/P: 5</para>You can allocate to the first, second and third child with 2, 1, 2 candies respectively</item>
///    <item>I/P: [1,2,2]<para>O/P: 4</para>You can allocate tothe first, second and third child with 1, 2, 1 candies respectively<para>Third satisfies the above two conditions</para></item>
/// </list>
/// </summary>
public class MinCandy : IProblem{
    
    public void EntryPoint(){
        
        var input  = new[] { 1, 2, 2 };
        var output = Calc(input);
        
        Display.Out(String.Join(',', input));
        Display.Out(output, 4);

    }

    public int Calc(int[] children) {
        int candies = children.Length;
        for (int i = 0; i <= (children.Length - 2); i++) {
            if (children[i].Equals(children[i + 1]))
                continue;
            candies++;
        }
        return candies;
    }

}
