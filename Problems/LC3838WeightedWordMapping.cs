using System.Text;

namespace Problems;

public class LC3838
{
    public string MapWordWeights(string[] words, int[] weights)
    {
        char l;
        int r = 0, o = 0, i = 0;
        StringBuilder sb = new();

        foreach(string word in words)
        {
            r = 0;

            for (i = 0; i < word.Length; i++)
                r += weights[word[i] - 'a'];

            o = (r % 26);
            r = (26 - o);
            l = (char)(r + 96);

            sb.Append(l);
        }

        return sb.ToString();
    }
}
