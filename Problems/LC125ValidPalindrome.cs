namespace Problems;

public class LC125
{
    public class SingleIteration
    {
        public bool IsPalindrome(string s)
        {
            // 11 ms Runtime        87 %
            // 44 Mb Memory         65 %
            // https://leetcode.com/problems/valid-palindrome/submissions/2121348966

            int l = 0, r = s.Length - 1;

            while (l <= r)
            {
                if (!Char.IsLetterOrDigit(s[l]))
                {
                    l++;
                    continue;
                }

                if (!Char.IsLetterOrDigit(s[r]))
                {
                    r--;
                    continue;
                }

                if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
                    return false;

                l++;
                r--;
            }

            return true;
        }
    }

    public class ExtraIteration
    {
        public bool IsPalindrome(string s)
        {
            // 11 ms Runtime        87 %
            // 45 Mb Memory         31 %
            // https://leetcode.com/problems/valid-palindrome/submissions/2121347092

            List<char> l = new();

            foreach (char c in s)
                if (Char.IsLetterOrDigit(c))
                    l.Add(Char.ToLower(c));

            if (l.Count == 0)
                return true;

            for (int i = 0, j = (l.Count - 1); i < j; i++, j--)
                if (l[i] != l[j])
                    return false;

            return true;
        }
    }
}