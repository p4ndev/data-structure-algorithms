namespace Problems;

public class LC3110
{
    public int ScoreOfString(string s)
    {
        int o = 0, i = 0, j = 1;

        while(j <= (s.Length - 1))
        {
            o += Math.Abs(s[i] - s[j]);
            i++;        j++;
        }

        return o;
    }
}
