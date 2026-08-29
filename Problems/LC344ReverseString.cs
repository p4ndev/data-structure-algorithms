namespace Problems;

public class LC344
{
    public void ReverseString(char[] s)
    {
        if (s.Length == 0)
            return;

        int i = 0, j = (s.Length - 1);

        while(i < j)
        {
            (s[i], s[j]) = (s[j], s[i]);
            i++; j--;
        }
    }
}