var inp = new List<long>();
var exp = 0;

/*

inp = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
exp = 5000000015;

|                     Method |     Mean |    Error |   StdDev |
|--------------------------- |---------:|---------:|---------:|
| aVeryBigSum_LINQ_BENCHMARK | 58.81 ns | 1.011 ns | 0.945 ns |
|      aVeryBigSum_BENCHMARK | 12.00 ns | 0.121 ns | 0.108 ns |

##############################################################################################################################################################

inp = new List<long>() { 1001458909, 1004570889, 1007019111, 1003302837, 1002514638, 1006431461, 1002575010, 1007514041, 1007548981, 1004402249 };
exp = 10047338126;

|                     Method |      Mean |    Error |   StdDev |
|--------------------------- |----------:|---------:|---------:|
| aVeryBigSum_LINQ_BENCHMARK | 102.32 ns | 0.210 ns | 0.186 ns |
|      aVeryBigSum_BENCHMARK |  21.70 ns | 0.457 ns | 0.508 ns |

##############################################################################################################################################################

inp = new List<long>() { -2147483648, 2147483647 };
exp = -1;

|                     Method |     Mean |    Error |   StdDev |
|--------------------------- |---------:|---------:|---------:|
| aVeryBigSum_LINQ_BENCHMARK | 56.66 ns | 1.123 ns | 1.337 ns |
|      aVeryBigSum_BENCHMARK | 29.87 ns | 0.629 ns | 0.922 ns |

*/

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

