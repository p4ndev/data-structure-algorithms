
Console.WriteLine(
    LibraryFine(
        28, 2, 2015,
        15, 4, 2015
    )
); // 0

Console.WriteLine(
    LibraryFine(
         2, 5, 2015,
        30, 5, 2015
    )
); // 0

Console.WriteLine(
    LibraryFine(
        2, 6, 2014,
        7, 6, 2014
    )
); // 0

// 20 min to understand
// 10 min to code

static int LibraryFine(int d1, int m1, int y1, int d2, int m2, int y2){

    // 4) returned after the calendar year
    if (y1 > y2)        return 10000;
    else if (y1 < y2)   return 0;

    // 1) returned on or before
    if (m1 < m2 && y1.Equals(y2)) return 0;

    // 2) returned after the expected return day,
    //    but still within the same calendar month and year
    int result;
    if (m1.Equals(m2)) {
        int late_days = d1 - d2;
        result = (15 * late_days);
        return (result < 0 ? 0 : result);
    }

    // 3) returned after the expected return month,
    //    but still within the same calendar year
    int late_months = (m1 - m2);
    result = (500 * late_months);
    return result < 0 ? 0 : result;

}

// wrong output values
// didnt cover cascade cases:
//      - years
//      - months
//      - negative days
