namespace Problems;

public class LC1876
{
    public int CountGoodSubstrings(string s)
    {
        int k = 3, o = -1;

        if (s.Length < 3)
            return o;

        int a = 0, p = 0;
        char l = s[a];
        int t = (l - 'a');

        for (int i = 1; i < k; i++) {

            if ((a + 1) > (s.Length - k))
                return o;

            p = (i + a);

            if (l == s[p]) {
                l = s[p];
                t = (l - 'a');
                a++;
                i--;
                continue;
            }

            l = s[p];
            t += (l - 'a');
        }


        return o;
    }
}