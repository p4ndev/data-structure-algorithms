public static class Positives{

	/*
	 * Time	: O(n)
	 * Space: O(1)    
	*/

	public static void Arrange(List<int> input){

		EdgeCase(input.Count <= 0);

		#region Declaration

		int? max;
		int x = 0, y = 0, z = 0;
		List<int> count = new(), output = new();

		#endregion

		#region Finding max/min

		max = input[0];
		CornerCase(max < 0);

		for (int i = 1; i < input.Count; i++){
			CornerCase(input[i] < 0);
			if (input[i] > max) max = input[i];
		}

		#endregion

		#region Filling count/output

		for (int i = 0; i < (max + 1); i++){
			count.Add(0);
			if(i < input.Count) output.Add(0);
		}

		#endregion

		#region Incrementing once found

		for (int i = 0; i < input.Count; i++){
			x = input[i];
			count[x]++;
		}

		#endregion

		#region Cumulative auxiliary index sum

		for (int i = 0; i < count.Count; i++){
			z = (i == 0 ? 0 : (i - 1));
			y = count[z];
			count[i] += y;
		}

		#endregion

		#region Placing items based on subtraction

		for (int i = 0; i < input.Count; i++){

			x = input[i];
			y = count[x];
			z = y - 1;

			output[z] = x;
			count[x]--;

		}

		#endregion

		#region Transfer data out

		for (int i = 0; i < input.Count; i++)
			input[i] = output[i];

		#endregion

	}

    private static void EdgeCase(bool predicate){
		if (predicate) throw new ArgumentException();
	}

	private static void CornerCase(bool predicate){
		if (predicate) throw new InvalidDataException();
	}

}