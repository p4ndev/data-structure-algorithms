namespace Problems;

public class LC20
{
    /*
    Runtime 7ms         20.10% beats
    Memory 42.22Mb      39.40% beats
    https://leetcode.com/problems/valid-parentheses/submissions/2058557237  
    */

    public bool IsValid_Mine(string s)
    {
        if (s.Length == 1 || ((s.Length % 2) != 0))
            return false;

        Stack<char> st = new();
        Dictionary<char, char> dc = new() {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        for (int i = (s.Length - 1); i >= 0; i--)
        {
            if (st.Count > 0 &&
                    dc.ContainsKey(s[i]) &&
                        dc[s[i]] == st.Peek())
            {
                st.Pop();
                continue;
            }

            st.Push(s[i]);
        }

        return (st.Count == 0);
    }

    public bool IsValid_Best_Runtime(string s)
    {
        if (string.IsNullOrEmpty(s))
            return true;

        var stack = new Stack<char>();

        for (var i = 0; i < s.Length; i++)
        {
            char value;
            switch (s[i])
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(s[i]);
                    break;

                case ')':
                    if (stack.Count == 0)   return false;
                    value = stack.Pop();                        
                    if (value != '(')       return false;
                    break;

                case ']':
                    if (stack.Count == 0)   return false;
                    value = stack.Pop();
                    if (value != '[')       return false;
                    break;

                case '}':
                    if (stack.Count == 0)   return false;
                    value = stack.Pop();
                    if (value != '{')       return false;
                    break;
            }
        }

        return (stack.Count == 0);
    }

    public bool IsValid_Best_Memory(string s)
    {
        Stack<char> stack = new();
        bool hasElements;
        char chs;

        foreach (char ch in s.ToCharArray())
        {
            switch (ch)
            {
                case ')':
                    hasElements = stack.TryPop(out chs);
                    if (!hasElements || chs != '(') return false;
                    break;

                case ']':
                    hasElements = stack.TryPop(out chs);
                    if (!hasElements || chs != '[') return false;
                    break;

                case '}':
                    hasElements = stack.TryPop(out chs);
                    if (!hasElements || chs != '{') return false;
                    break;

                default:
                    stack.Push(ch);
                    break;
            }
        }

        return stack.Count == 0;
    }
}
