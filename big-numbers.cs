using System.Numerics;

public static class BigSorting {

    // Input
    // "1", "345345345345345345345345", "28", "8633545", "4", "9"

    public static List<string> Arrange_Conversion(List<string> unsorted){

        if (unsorted.Count <= 0) return unsorted;

        BigInteger temp;
        SortedDictionary<BigInteger, int> dict = new();

        unsorted.ForEach(item => {

            temp = BigInteger.Parse(item);

            if (dict.ContainsKey(temp))
                dict[temp]++;
            else
                dict.Add(temp, 1);

        });

        var output = new List<string>();

        foreach (var item in dict){
            for (int i = 0; i < item.Value; i++)
                output.Add(item.Key.ToString());
        }

        return output;

    }

    public static List<string> Arrange_NoConversion(List<string> unsorted) {

        var output = unsorted.ToArray();

        Array.Sort(output, (next, current) => {
            if (next.Length < current.Length)
                return -1;
            else if (next.Length > current.Length)
                return 1;
            else{
                if (next == current)
                    return 0;
                else{
                    var i = 0;
                    while (next[i] == current[i]) i++;
                    return next[i].CompareTo(current[i]);
                }
            }
        });

        return output.ToList();

    }

}