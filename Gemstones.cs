
// Mistake: same char affect count at the end (edge case)

var input = new List<string>();
var result = 0;

input = new List<string>() { "abcdde", "baccd", "eeabg" };
result = Gemstones(input); // 2
Console.WriteLine(result);

input = new List<string>() { "vtrjvgbj", "mkmjyaeav", "sibzdmsk" };
result = Gemstones(input); // 0
Console.WriteLine(result);

input = new List<string>() { "basdfj", "asdlkjfdjsa", "bnafvfnsd", "oafhdlasd" };
result = Gemstones(input); // 4
Console.WriteLine(result);

static int Gemstones(List<string> arr){

    int total = 0;
    int toBeConsidered = arr.Count;
    var dict = new Dictionary<char, int>();

    foreach (var stone in arr)
        foreach (var mineral in stone.ToCharArray().Distinct()){
            if (dict.ContainsKey(mineral))
                dict[mineral]++;
            else
                dict.Add(mineral, 1);
        }

    total = dict.Count(m => m.Value >= toBeConsidered);
    return total;

}
