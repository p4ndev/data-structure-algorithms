
var input = new List<int>() { 5, 2, 3, 4, 1 };
var result = ClosestNumbers(input);
Console.WriteLine(String.Join(',', result));

var input = new List<int>() { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854 };
var result = ClosestNumbers(input); // -20 30
Console.WriteLine(String.Join(',', result));

static List<int> ClosestNumbers(List<int> arr){

    arr.Sort();
    int PAIRS = 2;
    if(arr.Count <= PAIRS) return arr;

    int? min = null;
    for(int i = 1; i <= (arr.Count - PAIRS); i++){
        
        int op = Math.Abs(arr[i + 1] - arr[i]);

        if (!min.HasValue) {
            min = op;
            continue;
        }

        if (op < min.Value)
            min = op;

    }

    var res = new List<int>();
    for (int i = 0; i <= (arr.Count - PAIRS); i++){
        int op = (arr[i + 1] - arr[i]);
        if (op.Equals(min)) {
            res.Add(arr[i]);
            res.Add(arr[i + 1]);
        }
    }

    return res;
        
}