
Console.WriteLine(AppendAndDelete("abc", "def", 6));                    // YES
Console.WriteLine(AppendAndDelete("aba", "aba", 7));                    // YES
Console.WriteLine(AppendAndDelete("hackerhappy", "hackerrank", 9));     // YES
Console.WriteLine(AppendAndDelete("ashley", "ash", 2));                 // NO

static string AppendAndDelete(string s, string t, int k){
    
    int tmp = (s.Length + t.Length);
    if (tmp <= k) return "Yes";

    int i = 0;
    while ((i < s.Length) && (i < t.Length) && s[i].Equals(t[i]))
        i++;

    tmp = 0;
    if (i < s.Length) tmp += s.Length - i;
    if (i < t.Length) tmp += t.Length - i;

    bool fullyEven = ((k - tmp) % 2).Equals(0);
    if (tmp <= k && fullyEven) return "Yes";

    return "No";

}