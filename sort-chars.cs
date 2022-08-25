public static class Chars{

	/*
	 * Time	: O(1)
	 * Space: O(1)
	*/

	public static void Arrange(char[] arr) {

		// Declaration
		int x, y, n		= arr.Length;
		char[] output	= new char[n];
		int[] count		= new int[256];

		// Incrementing once found
		for (int i = 0; i < n; ++i) ++count[arr[i]];

		// Cumulative auxiliary index sum
		for (int i = 1; i <= 255; ++i)	count[i] += count[i - 1];

		// Placing items based on subtraction (reverse order)
		for (int i = (n - 1); i >= 0; i--){

			x = arr[i];

			y = count[x] - 1;

			output[y] = arr[i];

			--count[x];

		}

		// Transfer data out
		for (int i = 0; i < n; ++i)	arr[i] = output[i];

	}


}