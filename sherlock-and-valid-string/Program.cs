Console.WriteLine("EXP: {0} O/P: {1}", "NO", isValid("abccc"));
Console.WriteLine("EXP: {0} O/P: {1}", "NO", isValid("aabbcd"));
Console.WriteLine("EXP: {0} O/P: {1}", "NO", isValid("aabbccddeefghi"));

Console.WriteLine("EXP: {0} O/P: {1}", "YES", isValid("aabbcc"));
Console.WriteLine("EXP: {0} O/P: {1}", "YES", isValid("aabbccd"));
Console.WriteLine("EXP: {0} O/P: {1}", "YES", isValid("aaabbcc"));
Console.WriteLine("EXP: {0} O/P: {1}", "YES", isValid("a"));
Console.WriteLine("EXP: {0} O/P: {1}", "YES", isValid("abc"));
Console.WriteLine("EXP: {0} O/P: {1}", "YES", isValid("abcc"));
Console.WriteLine("EXP: {0} O/P: {1}", "YES", isValid("abbac"));
Console.WriteLine("EXP: {0} O/P: {1}", "YES", isValid("aabbc"));
Console.WriteLine("EXP: {0} O/P: {1}", "YES", isValid("abcdefghhgfedecba"));
Console.WriteLine("EXP: {0} O/P: {1}", "YES", isValid("ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd"));

string isValid(string s)
{
    Dictionary<char, int> charCount = new();

    foreach (char c in s)
    {
        if (charCount.ContainsKey(c))
            charCount[c]++;
        else
            charCount[c] = 1;
    }

    Dictionary<int, int> countCheck = new();

    foreach (int v in charCount.Values)
    {
        if (countCheck.ContainsKey(v))
            countCheck[v]++;
        else
            countCheck[v] = 1;
    }

    if (countCheck.Count == 1)
        return "YES";

    if (countCheck.Count > 2)
        return "NO";

    bool hasOne = false;

    foreach (int value in countCheck.Values)
    {
        if (value == 1)
        {
            hasOne = true;
            break;
        }
    }

    if (!hasOne)
        return "NO";

    int bigKey = int.MinValue;
    int smallKey = int.MaxValue;

    foreach (int key in countCheck.Keys)
    {
        if (key > bigKey)
            bigKey = key;

        if (key < smallKey)
            smallKey = key;
    }

    if (smallKey == 1 && countCheck[1] == 1)
        return "YES";

    if (countCheck[bigKey] == 1 && (bigKey - smallKey) == 1)
        return "YES";

    return "NO";
}
