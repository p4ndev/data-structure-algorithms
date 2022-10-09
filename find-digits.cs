
Console.WriteLine(FindDigits(124));     // Expected: 3
Console.WriteLine(FindDigits(11));      // Expected: 3
Console.WriteLine(FindDigits(10));      // Expected: 1

// Poorest solition but accepted
// 14 minutes total

static int FindDigits(int n){

    int str = n, cou = 0, tmp = 0;

    while (str > 0) {
        tmp = (str % 10);
        if (!tmp.Equals(0)) {
            if ((n % tmp).Equals(0))
                cou++;
        }
        str /= 10;
    }

    return cou;

}
