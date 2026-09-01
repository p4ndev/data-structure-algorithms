namespace Problems;

public class LC1876
{
    public int CountGoodSubstringsExtraSpace(string s) {
        
        // Runtime  : 1 ms       48%
        // Memory   : 40 Mb       7%
        // https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/submissions/2126674345
        
        int o = 0;

        for (int i = 0; i <= (s.Length - 3); i++)
            if (new HashSet<char>() {
                s[i],       // Left
                s[i + 1],   // Middle
                s[i + 2]    // Right
            }.Count == 3)
                o++;

        return o;
    }

    public int CountGoodSubstringsLinear(string s) {

        // Runtime  : 0 ms        100%
        // Memory   : 38 Mb        65%
        // https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/submissions/2126674811

        int o = 0;
        char l, m, r;

        for (int i = 0; i <= s.Length - 3; i++)
        {
            l = s[i];       // Left
            m = s[i + 1];   // Middle
            r = s[i + 2];   // Right

            if (l != m && l != r && m != r)
                o++;
        }

        return o;
    }
}