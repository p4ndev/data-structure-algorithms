var inp = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
var exp = 5000000015;

//inp = new List<long>() { 1001458909, 1004570889, 1007019111, 1003302837, 1002514638, 1006431461, 1002575010, 1007514041, 1007548981, 1004402249 };
//exp = 10047338126;

// inp = new List<long>() { -2147483648, 2147483647 };
// exp = -1;

var res = aVeryBigSum(inp);
Console.ForegroundColor = res.Equals(exp) ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine(res);

static long aVeryBigSum(List<long> ar) {
    if (ar.Count <= 0) return 0;
    long output = 0;
    foreach (long number in ar){
        if (number < int.MinValue || number > int.MaxValue) return 0;
        output += number;
    }
    return output;
}