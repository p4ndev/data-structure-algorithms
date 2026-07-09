using System.Text;

namespace Problems;

public class LC14
{
    public string LongestCommonPrefix(string[] input)
    {
        var sb = new StringBuilder();
        int idx = -1, counter = 0;
        char[] min;

        for (int i = 0; i < input.Length; i++)
            if (idx == -1 || counter > input[i].Length)
            {
                idx = i;
                counter = input[i].Length;
            }

        if (idx == -1) return string.Empty;
        min = input[idx].ToCharArray();

        for (int l = 0; l < min.Length; l++)
        {
            char t = min[l];

            for (int i = 0; i < input.Length; i++)
                if (input[i].Length <= l || input[i][l] != t)
                    return sb.ToString();

            sb.Append(t);
        }

        return sb.ToString();
    }
}
