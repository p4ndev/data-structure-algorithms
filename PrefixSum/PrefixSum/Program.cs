// [ Y ] https://www.geeksforgeeks.org/dsa/equilibrium-index-of-an-array/

int expected = 2;
int[] arr = { 1, 2, 0, 3 };

//int expected = 3;
//int[] arr = { 1, -1, 1, -1, 0 };

//int expected = -1;
//int[] arr = { 1, 1, 1, 1 };

//int expected = 3;
//int[] arr = { -7, 1, 5, 2, -4, 3, 0 };

//int expected = 4;
//int[] arr = { 1, 2, 3, 4, 6 };

int result = Equilibrium.Find(arr);

Console.WriteLine(string.Join(",", result));
Console.WriteLine(string.Join(",", expected));

























// [ Y ] https://www.geeksforgeeks.org/dsa/split-array-two-equal-sum-subarrays/

//bool expected = true;
//int[] arr = { 1, 2, 3, 4, 5, 5 };

//bool expected = false;
//int[] arr = { 4, 3, 2, 1 };

//bool expected = true;
//int[] arr = { 1, 2, 3 };

//bool expected = false;
//int[] arr = { 1, 1, 1, 1, 1 };

//bool expected = true;
//int[] arr = { 6, 3, 2, 1 };

//bool expected = false;
//int[] arr = { 100, 1, 1, 1, 1, 1 };

//bool result = Split.IsAbleTo(arr);

//Console.ForegroundColor = (result == expected ? ConsoleColor.Green : ConsoleColor.Red);
//Console.WriteLine("The array items [{0}] is {1}able to split.", string.Join(",", arr), (result ? "" : "not "));
//Console.ResetColor();











// [ Y ] https://www.geeksforgeeks.org/dsa/mean-range-array/

//int[] arr = { 3, 7, 2, 8, 2 };
//List<int> expected = new() { 5, 5, 4 };
//int[][] queries = { [0, 1], [1, 3], [2, 4] };

//int[] arr = { 10, 20, 30, 40, 50, 60 };
//List<int> expected = new() { 50 };
//int[][] queries = { [3, 5] };

//int[] arr = { 1, 2, 3, 4, 5 };
//List<int> expected = new() { 1, 2, 3 };
//int[][] queries = { [0, 0], [1, 1], [2, 2] };

//int[] arr = {
//    81, 14, 3, 94, 35,
//    31, 28, 17, 94, 13,
//    86, 94, 69, 11, 75,
//    54, 4, 3, 11, 27,
//    29, 64, 77, 3, 71,
//    25, 91, 83, 89, 69
//};

//List<int> expected = [
//    81,
//    43,
//    41,
//    48,
//    41,
//    51,
//    43,
//    46,
//    47,
//    43,
//    69,
//    44
//];

//int[][] queries = {
//    [0, 0],
//    [0, 5],
//    [0, 9],
//    [0, 29],
//    [1, 10],
//    [5, 14],
//    [10, 19],
//    [15, 29],
//    [3, 17],
//    [7, 23],
//    [12, 12],
//    [20, 25]
//};

//List<int> result = Mean.Find(arr, queries);

//Console.WriteLine("Result(s):\t\t{0}", string.Join(",", result));
//Console.WriteLine("Expectation(s):\t\t{0}", string.Join(",", expected));

















// [ Y ] https://www.geeksforgeeks.org/dsa/find-original-array-from-given-prefix-sum-array/

//int[] presum = new int[] { 45, 57, 63, 78, 89, 97 };
//int[] expected = new int[] { 45, 12, 6, 15, 11, 8 };

//int[] arr = Presum.DecodeArray(presum);

//Console.WriteLine(string.Join(",", presum));
//Console.WriteLine(string.Join(",", expected));
