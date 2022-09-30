
Console.WriteLine(DayOfProgrammer(1800) + " should be 12.09.1800");
Console.WriteLine(DayOfProgrammer(1984) + " should be 12.09.1984");
Console.WriteLine(DayOfProgrammer(2017) + " should be 13.09.2017");
Console.WriteLine(DayOfProgrammer(2016) + " should be 12.09.2016");

// ============================================================================================================

static string DayOfProgrammer(int year){

    bool? isLeap = null;
    if (year > 1918) // Gregorian
        isLeap = ((year % 400).Equals(0) || ((year % 4).Equals(0) && !(year % 100).Equals(0)));
    else if (year < 1918) // Julian
        isLeap = (year % 4).Equals(0);

    switch (isLeap) {
        case true:  return "12.09." + year;
        case false: return "13.09." + year;
        default:    return "26.09.1918";
    }

}