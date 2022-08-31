public static class PositivesAndNegatives {

	/*
	 * Time	: O(n)
	 * Space: O(1)
	*/

	public static void Arrange(List<int> input){

		if(input.Count <= 0) throw new ArgumentException();

		#region Declaration

		int x, y, z;
		int min, max, range;
		int[] count, output;
		
		#endregion

		#region Finding max/min

		min = input[0];
		max = input[0];

		for (int i = 1; i < input.Count; i++){
			if (input[i] > max) max = input[i];
			if (input[i] < min) min = input[i];
		}

		range = (max - min) + 1;

		#endregion

		#region Declaration arrays

		count = new int[range];
		output = new int[input.Count];

		#endregion

		#region Incrementing once found

		for (int i = 0; i < input.Count; i++){
			x = input[i] - min;
			count[x]++;
		}

		#endregion

		#region Cumulative auxiliary index sum

		for(int i = 1; i < count.Length; i++){
			x = (i - 1);
			count[i] += count[x];
        }

		#endregion

		#region Placing items based on subtraction

		for (int i = (input.Count - 1); i >= 0; i--) {

			x = input[i] - min;
			y = count[x] - 1;

			output[y] = input[i];
			count[x]--;

		}

		#endregion

		#region Transfer data out

		for(int i = 0; i < input.Count; i++)
			input[i] = output[i];

		#endregion

	}

}