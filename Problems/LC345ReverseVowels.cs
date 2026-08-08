namespace Problems;

public class LC345
{
    public string ReverseVowels(string s)
    {
        char[] a = s.ToCharArray();
        List<KeyValuePair<char, int>> p = new();
        HashSet<char> v = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        for (int i = 0; i < a.Length; i++)
            if(v.Contains(s[i]))
                p.Add(new(s[i], i));

        if (p.Count >= 2)
            for (int i = 0, j = (p.Count - 1); i < j; i++, j--)
            {
                var l = p[i];
                var r = p[j];

                if (l.Key == r.Key)
                    continue;

                a[l.Value] = r.Key;
                a[r.Value] = l.Key;
            }

        return string.Join("", a);
    }
}