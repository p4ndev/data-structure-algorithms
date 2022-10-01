
Console.WriteLine(SeparateNumbers("1234"));                                 // YES 1
Console.WriteLine(SeparateNumbers("91011"));                                // YES 9
Console.WriteLine(SeparateNumbers("7891011"));                              // YES 7
Console.WriteLine(SeparateNumbers("99100"));                                // YES 99
Console.WriteLine(SeparateNumbers("9899100"));                              // YES 98
Console.WriteLine(SeparateNumbers("99910001001"));                          // YES 999
Console.WriteLine(SeparateNumbers("101103"));                               // NO
Console.WriteLine(SeparateNumbers("999100010001"));                         // NO
Console.WriteLine(SeparateNumbers("1"));                                    // NO
Console.WriteLine(SeparateNumbers("429496729542949672964294967297"));       // YES 4294967295
Console.WriteLine(SeparateNumbers("429496729542949672964294967296"));       // NO
Console.WriteLine(SeparateNumbers("429496729542949672964294967287"));       // NO
Console.WriteLine(SeparateNumbers("429496729542949672964294967197"));       // NO
Console.WriteLine(SeparateNumbers("42949672954294967296429496729"));        // NO
Console.WriteLine(SeparateNumbers("4294967295429496729642949672"));         // NO
Console.WriteLine(SeparateNumbers("429496729500000000000000000001"));       // NO
Console.WriteLine(SeparateNumbers("42949672950123456789"));                 // NO
Console.WriteLine(SeparateNumbers("4294967295000010020030000456789"));      // NO
Console.WriteLine(SeparateNumbers("4294967295000102003004005"));            // NO

static string SeparateNumbers(string s){

    int half = (s.Length / 2);      var sb = new System.Text.StringBuilder();
    long? n = null;                 string tmp = string.Empty;
    string root = string.Empty;

    for (int i = 1; i <= half; i++) {

        tmp = s.Substring(0, i);        
        if (tmp.StartsWith("0"))            break;
        n = Convert.ToInt64(tmp);
        sb.Append(n);

        while (sb.Length < s.Length) {            
            sb.Append(++n);
            if(sb.Length <= s.Length){
                root = s.Substring(0, sb.Length);
                if (!sb.Equals(root))       break;
            }
        }

        if (sb.Equals(s))                   break;
        sb.Clear();                         n = null;

    }

    return (n is null ? "NO" : ("YES " + tmp));

}