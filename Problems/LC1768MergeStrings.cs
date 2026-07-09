using System.Text;

namespace Problems;

public class LC1768
{
    /*
    70ms Runtime	Beats 18%		39 Mb Memory		Beats 85%
    https://leetcode.com/problems/merge-strings-alternately/submissions/2029929824 
    */
    public string MergeAlternately(string word1, string word2)
    {
        if (String.IsNullOrWhiteSpace(word1) &&
             String.IsNullOrWhiteSpace(word2))
            return string.Empty;

        if (!String.IsNullOrWhiteSpace(word1) &&
             String.IsNullOrWhiteSpace(word2))
            return word1;

        if (String.IsNullOrWhiteSpace(word1) &&
             !String.IsNullOrWhiteSpace(word2))
            return word2;

        int steps = word1.Length;
        if (word2.Length > steps)
            steps = word2.Length;

        var sb = new StringBuilder();

        for (int i = 0; i < steps; i++)
        {
            if (i < word1.Length)
                sb.Append(word1[i]);

            if (i < word2.Length)
                sb.Append(word2[i]);
        }

        return sb.ToString();
    }
}





/*
Usar isso:
int maxLength = Math.Max(word1.Length,word2.Length);

Ao invés de fazer na mão:
int steps = word1.Length;
if(word2.Length > steps)
	    steps = word2.Length;
*/






/*
Quem bateu o máximo de eficiência não foi até o final do LOOP,
fez um substring após o menor concluir o merge do menor (menos execuções). 
*/