
Console.WriteLine(RepeatedString("ababa",             3 ));   // 2
Console.WriteLine(RepeatedString("bcde" ,           864 ));   // 0
Console.WriteLine(RepeatedString("a"    ,            45 ));   // 45
Console.WriteLine(RepeatedString("abcac",            10 ));   // 4
Console.WriteLine(RepeatedString("a"    , 1000000000000 ));   // 1000000000000

static long RepeatedString(string s, long n){
    if (s.Equals('a')) return n;
    long r  = (n - s.Length);
    if (r <= 0) return s.Take(Convert.ToInt32(n)).LongCount(l => l.Equals('a'));
    long i  = s.LongCount(l => l.Equals('a'));
    if (i.Equals(0)) return 0;
    long b  = (r / s.Length);
    int  o  = Convert.ToInt32(r % s.Length);
    long e  = ((o <= 0) ? 0 : s.Take(o).LongCount(l => l.Equals('a')));
    return (((b + 1) * i) + e);
}