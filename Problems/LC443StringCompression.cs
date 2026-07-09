namespace Problems;

public class LC443
{
    /*
    3ms Runtime	75% Beats		62 Mb Memory	60% Beats
    https://leetcode.com/problems/string-compression/submissions/2030219117 
    */
    public int StringCompression(char[] chars)
    {
        int write = 0;
        int read = 0;

        while (read < chars.Length)
        {
            char current = chars[read];
            int count = 0;

            while (read < chars.Length && chars[read] == current)
            {
                read++;
                count++;
            }

            chars[write++] = current;

            if (count > 1)
                foreach (char digit in count.ToString())
                {
                    chars[write++] = digit;
                }
        }

        return write;
    }
}
