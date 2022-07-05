
var inp = new List<int> { 2, 3, 1, 8, 3, 4, 2 };
CountSortOnlyPositives(inp);

/*    Time: O(n) ||||||||||||||||| Space: O(n)    */
static void CountSortOnlyPositives(List<int> input){

	if (input.Count <= 0) return;

	#region Declaration

	int? max;
	int x = 0, y = 0, z = 0;
	List<int> count = new(), output = new();

	#endregion

	#region Finding max number

	max = input[0];
	output.Add(0);

	for (int i = 1; i < input.Count; i++)
	{
		if (input[i] > max)
			max = input[i];
		output.Add(0);
	}

	#endregion

	#region Filling aux array with 0

	for (int i = 0; i < (max + 1); i++)
		count.Add(0);

	#endregion

	#region Incrementing once found

	for (int i = 0; i < input.Count; i++){
		x = input[i];
		count[x]++;
	}

	#endregion

	#region Cumulative auxiliary index sum

	for (int i = 0; i < count.Count; i++)
	{
		z = (i == 0 ? 0 : (i - 1));
		y = count[z];
		count[i] += y;
	}

	#endregion

	#region Placing items based on subtraction

	for (int i = 0; i < input.Count; i++)
	{

		x = input[i];
		y = count[x];
		z = y - 1;

		output[z] = x;
		count[x]--;

	}

	#endregion

	Console.WriteLine("Input:\n{0}", String.Join(",", input));
	Console.WriteLine("\nOutput:\n{0}", String.Join(",", output));
	Console.ReadKey();

}