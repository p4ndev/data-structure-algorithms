// [ Y ] https://www.geeksforgeeks.org/dsa/split-array-two-equal-sum-subarrays/

//bool expected = true;
//int[] arr = { 1, 2, 3, 4, 5, 5 };

//bool expected = false;
//int[] arr = { 4, 3, 2, 1 };

//bool expected = true;
//int[] arr = { 1, 2, 3 };

//bool expected = false;
//int[] arr = { 1, 1, 1, 1, 1 };

bool expected = true;
int[] arr = { 6, 3, 2, 1 };

//bool expected = false;
//int[] arr = { 100, 1, 1, 1, 1, 1 };

bool result = Split.IsAbleTo(arr);

Console.ForegroundColor = (result == expected ? ConsoleColor.Green : ConsoleColor.Red);
Console.WriteLine("The array items [{0}] is {1}able to split.", string.Join(",", arr), (result ? "" : "not "));
Console.ResetColor();












// [   ] https://www.geeksforgeeks.org/dsa/equilibrium-index-of-an-array/

//int expected = 2;
//int[] arr = { 1, 2, 0, 3 };

//int result = Equilibrium.Find(arr);

//Console.WriteLine(string.Join(",", result));
//Console.WriteLine(string.Join(",", expected));
















// [   ] https://www.geeksforgeeks.org/dsa/mean-range-array/

//int[] arr = { 3, 7, 2, 8, 2 };
//List<int> expected = new() { 5, 5, 4 };
//int[][] queries = { [0, 1], [1, 3], [2, 4] };

//List<int> result = Mean.Find(arr, queries);

//Console.WriteLine(string.Join(",", result));
//Console.WriteLine(string.Join(",", expected));

















// [ Y ] https://www.geeksforgeeks.org/dsa/find-original-array-from-given-prefix-sum-array/

//int[] presum = new int[] { 45, 57, 63, 78, 89, 97 };
//int[] expected = new int[] { 45, 12, 6, 15, 11, 8 };

//int[] arr = Presum.DecodeArray(presum);

//Console.WriteLine(string.Join(",", presum));
//Console.WriteLine(string.Join(",", expected));
