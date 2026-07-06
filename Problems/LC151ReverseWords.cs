using System.Text;

namespace Problems
{
    public class LC151ReverseWords
    {
        public string ReverseWords_Naive_Best(string s)
            => string.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());

        /*
        4ms Runtime 	48% Beats 		42 Mb Memory		29% Beats
        https://leetcode.com/problems/reverse-words-in-a-string/submissions/2030199810 
        */
        public string ReverseWords_ExtraSpace(string s)
        {
            var c = new List<string>();
            var sb = new StringBuilder();

            foreach (string i in s.Split(' '))
                if (!string.IsNullOrWhiteSpace(i))
                    c.Add(i);

            for (int l = (c.Count - 1); l >= 0; l--)
                sb.Append(" ").Append(c[l]);

            return sb.ToString().Substring(1);
        }

        /*
        4ms Runtime	48% Beats		42 Mb Memory		36% Beats
        https://leetcode.com/problems/reverse-words-in-a-string/submissions/2030201555 
        */
        public string ReverseWords_ExtraSpace_Simplified(string input)
        {
            var stack = new Stack<string>();

            foreach (var word in input.Split(' '))
                if (!string.IsNullOrWhiteSpace(word))
                    stack.Push(word);

            return string.Join(" ", stack);
        }
    }
}
