public static class Zero2Cem {

	// Input
	// 1, 4, 1, 1, 2, 6

	public static List<int> Arrange(List<int> arr){

		int i, len, idx;
		int[] output = new int[100];

		len = arr.Count;
		if (len <= 0) return arr;

		for (i = 0; i < len; i++) {
			idx = arr[i];
			output[idx]++;
		}

		return output.ToList();

	}

}