
int[]  arr = { 16, 3, 17, 2, 18, 4, 1, 19, 20, 5, 7, 8, 9, 10, 13, 14, 6, 11, 12, 15 };
string str = string.Empty;

str  = String.Join(',', arr) + Environment.NewLine;
SelectionSort(arr);
str += String.Join(',', arr) + Environment.NewLine;
Console.WriteLine(str);

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

static void SelectionSort(int[] arr) {

    for (int i, m = 0; m < arr.Length; m++) {

                // M : Main
        i = m;  // I : Inner
                // J : Accumulator

        for (int j = (m + 1); j < arr.Length; j++) // 'till rest of the elements
            if (arr[i] > arr[j]) // once min found, consider it
                i = j; // Cannot break, due to future numbers might be found

        if (!i.Equals(m)) {     // Both indexes aren't equal, then swap
            var t = arr[m];
            arr[m] = arr[i];
            arr[i] = t;
        }

    }

}
