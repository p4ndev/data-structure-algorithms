namespace Hard;

/// <summary>
/// Given a string containing just the characters '(' and ')'.
/// <para>Find the length of the longest valid (well-formed) parentheses substring.</para>
/// </summary>
public class LongestValidParentheses : IProblem{

    public void EntryPoint(){
        
        string  input    = "((()";
        int     output   = Find(input);

        Display.Out(input);
        Display.Out(output, 2);

    }

    private int Find(string t){

        int c = 0;
        if (t.Length <= 0) return c;

        Stack<int> s = new();
        s.Push(t[0]);

        foreach (char l in t.Substring(1)) {
            if (s.Peek().Equals('(') && l.Equals(')')) {
                s.Pop();
                c += 2;
                continue;
            }
            s.Push(l);
        }

        return c;

    }
}
