int amount = 4;
var input = new List<int>() { 2, 2, 4, 3, 6, 3, 8, 1 };
                           // [1º,2º] [4º,8º] [6º,8º]

var result = IceCreamParlor(amount, input);
Console.WriteLine(String.Join(',', result));

static List<int> IceCreamParlor(int m, List<int> arr){

    int dif, idx, i, j;
    var pairs = new List<int>();

    for (i = 0; i < arr.Count; i++) {
        
        idx = -1;
        dif = (m - arr[i]);

        for (j = (i + 1); j < arr.Count; j++)
            if (arr[j].Equals(dif)){
                idx = j;
                break;
            }

        if (idx >= 0) {
            pairs.Add(i + 1);
            pairs.Add(idx + 1);
        }

    }

    return pairs;

}