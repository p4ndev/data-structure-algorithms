/// <summary>
/// Confirm if a word is a valid palindrome
/// </summary>
public class ValidPalindrome : ProblemAbstraction<string, bool, bool>, ProblemContract
{
    public void Initialize()
    {
        Expected = true;
        Input = "";
        Output = Run(Input);
        Review();

        Expected = true;
        Input = "racecar";
        Output = Run(Input);
        Review();

        Expected = false;
        Input = "raceacar";
        Output = Run(Input);
        Review();

        Expected = true;
        Input = " ";
        Output = Run(Input);
        Review();

        Expected = true;
        Input = "arara";
        Output = Run(Input);
        Review();

        Expected = false;
        Input = "maria";
        Output = Run(Input);
        Review();
    }

    private bool Run(string s)
    {
        for (int i = 0, j = (s.Length - 1); i < j; i++, j--)
            if (s[i] != s[j])
                return false;

        return true;
    }
}