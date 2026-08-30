namespace Problems;

public class LC1876
{
    public int CountGoodSubstrings(string s) {
        int k = 3, o = 0;

        if (s.Length < 3)
            return o;

        int a = 0, p = 0;
        char l = s[a];
        int t = (l - 'a');

        for (int i = 1; i < k; i++) {
            p = (i + a);

            if (s.Length != k) {
                if ((a + 1) > (s.Length - k))
                    return o;

                if (l == s[p]) {
                    l = s[p];
                    t = (l - 'a');
                    a++;
                    i--;
                    continue;
                }
            }
            else if (l == s[p])
                return o;

            l = s[p];
            t += (l - 'a');
        }

        o++;
        if (s.Length == k)
            return o;

        // review other combinations within the rest of the array

        return o;
    }
}