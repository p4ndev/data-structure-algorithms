/// <summary>
/// Swap internal characters without consider the edges (first and last)
/// </summary>
public class SwapCharacters : ProblemAbstraction<string, string, string>, ProblemContract
{
    public void Initialize()
    {
        // 1. Regular case
        Input = "a12345z";
        Expected = "a54321z";
        Output = Run(Input);
        Review();

        // 2. Palindrome
        Input = "racecar";
        Expected = "racecar";
        Output = Run(Input);
        Review();

        // 3. Minimum size (2 characters)
        Input = "ab";
        Expected = "ab";
        Output = Run(Input);
        Review();

        // 4. Minimum size with one internal character
        Input = "abc";
        Expected = "abc";
        Output = Run(Input);
        Review();

        // 5. Even number of characters
        Input = "abcdef";
        Expected = "aedcbf";
        Output = Run(Input);
        Review();

        // 6. Odd number of characters
        Input = "abcdefg";
        Expected = "afedcbg";
        Output = Run(Input);
        Review();

        // 7. Empty string
        Input = "";
        Expected = "";
        Output = Run(Input);
        Review();

        // 8. Two identical edges
        Input = "a12345a";
        Expected = "a54321a";
        Output = Run(Input);
        Review();

        // 9. Spaces inside the string
        Input = "a b c d";
        Expected = "a c b d";
        Output = Run(Input);
        Review();

        // 10. Special characters
        Input = "#abc123!";
        Expected = "#321cba!";
        Output = Run(Input);
        Review();
    }

    private string Run(string s)
    {
        if (String.IsNullOrEmpty(s))
            return string.Empty;

        if (s.Length <= 2)
            return s;

        char[] o = s.ToCharArray();

        for (int i = 1, j = (s.Length - 2); i < j; i++, j--)
            (o[i], o[j]) = (o[j], o[i]);

        return new string(o);
    }
}