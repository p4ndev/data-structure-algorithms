using System.Text;

namespace Problems;

public class LC1071
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1.Length == str2.Length)
            return str1 == str2 ? str1 : "";

        StringBuilder sb = new();

        string minTerm = str1.Length <= str2.Length ? str1 : str2,
               maxTerm = str1.Length > str2.Length ? str1 : str2;

        while (minTerm != "")
        {
            if (maxTerm.Length % minTerm.Length == 0)
            {
                sb.Clear();

                for (int i = 0; i < maxTerm.Length / minTerm.Length; i++)
                    sb.Append(minTerm);

                if (sb.ToString() == maxTerm)
                {
                    sb.Clear();

                    for (int i = 0; i < str1.Length / minTerm.Length; i++)
                        sb.Append(minTerm);

                    if (sb.ToString() != str1)
                    {
                        minTerm = minTerm.Substring(0, minTerm.Length - 1);
                        continue;
                    }

                    sb.Clear();

                    for (int i = 0; i < str2.Length / minTerm.Length; i++)
                        sb.Append(minTerm);

                    if (sb.ToString() == str2)
                        return minTerm;
                }
            }

            minTerm = minTerm.Substring(0, minTerm.Length - 1);
        }

        return "";
    }
}
