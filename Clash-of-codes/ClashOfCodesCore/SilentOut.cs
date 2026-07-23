using System.Text;

namespace Problems;

/*

You may have heard of the children song which is sung repeatedly.
Each round one keyword is left out untill all keywords are silent.
The replacemente each round is the understand (_).

    "HEAD SHOULDERS KNEES TOES"
    "_ SHOULDERS KNEES TOES"
    "_ _ KNEES TOES"
    "_ _ _ TOES"
    "_ _ _ _"

There are also different versions of this verse, where only one letter is removed from a keyword.
In the german song the removing is starting at the back of the keyword.

    "auf der mauer, auf der lauer, sitzt ne kleine WANZE"

    "WANZ_"
    "WAN__"
    "WA___"
    "W____"
    "_____"

Constraints
    T => WORD or LETTER
    D => FRONT or BACK

*/

public partial class ClashOfCodeCore
{
    public void SilentOut(string i, int k, DataType t, Direction d)
    {
        int l = -k, r = k, e = 0, o = 0;
        var sb0 = new StringBuilder();
        var sb1 = new StringBuilder();
        var s = new string[k];

        if (t.Equals(DataType.WORD))
            s = [..i.Split(' ')];
        else
            for (int j = 0; j < k; j++)
                s[j] = i[j].ToString();

        if (d.Equals(Direction.BACK))
        {
            l *= 2;
            e = -k-1;
            r++;
        }

        while (l <= e)
        {
            o = (r + l);
            
            if (o < 0) o *= -1;
            if (o >= k) break;

            s[o] = "_";
            sb1.Clear();

            foreach (string c in s)
                sb1.Append(c).Append(" ");
            
            sb0
                .Append(sb1.ToString().TrimEnd())
                    .AppendLine();

            l++;
        }

        Console.Write(sb0.ToString());
    }
}
