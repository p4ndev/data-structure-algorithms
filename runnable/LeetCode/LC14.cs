using System.Text;

public class LC14LongestCommonPrefix
{
    public static string Execute(string[] strs)
    {
        int? skipIndex = null;
        int minLength = 0;

        for (int s = 0; s < strs.Length; s++) {
            if(!skipIndex.HasValue || minLength > strs[s].Length)
            {
                skipIndex = s;
                minLength = strs[s].Length;
            }
        }

        if (!skipIndex.HasValue)
            return string.Empty;

        char[] letters = strs[skipIndex!.Value].ToCharArray();
        StringBuilder sb = new();

        for(int l = 0; l < letters.Length; l++)
        {
            for(int s = 0; s < strs.Length; s++)
            {
                if (skipIndex!.Value == s)
                    continue;

                if (strs[s][l] != letters[l])
                    return sb.ToString();
            }

            sb.Append(letters[l]);
        }

        return sb.ToString();
    }
}



//var input = new string[] { "carry", "car", "cartoon" };
//var output = "car";

//var input = new string[] { "flow", "flower", "flight" };
//var output = "fl";

//var input = new string[] { "abc", "a", "abcd" };
//var output = "a";

//var input = new string[] { "racecar", "car", "dog" };
//var output = "";

//var result = LC14LongestCommonPrefix.Execute(input);

//Console.WriteLine(result);
//Console.WriteLine(output);