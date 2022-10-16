
int[] arr = { 3, 6, 2, 4, 1, 5 };
Console.WriteLine(String.Join(',', arr));
InsertionSort(arr);
Console.WriteLine(String.Join(',', arr));

static void InsertionSort(int[] arr) {

    for (int j, t, i = 0; i < arr.Length; i++) {

                    // I : Main
        t = arr[i]; // T : Temporary
        j = i;      // J : Inner

        while ((j > 0) && (arr[j - 1] > t)) { // 'till gt temp data
            arr[j] = arr[j - 1];              // Swap previous to current
            j--;
        }

        arr[j] = t; // After quit loop (right index),
                    // place data where it should be.

    }

}
