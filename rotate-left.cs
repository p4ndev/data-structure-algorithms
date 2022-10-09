
int rotation = 2; // Expected: { 3, 4, 5, 1, 2 }
var input = new List<int>() { 1, 2, 3, 4, 5 };
Console.WriteLine(String.Join(',', RotateLeft(rotation, input)));

rotation = 8; // Expected: { 4, 5, 1, 2, 3 }
input = new List<int>() { 1, 2, 3, 4, 5 };
Console.WriteLine(String.Join(',', RotateLeft(rotation, input)));

rotation = 4; // Expected: { 5, 1, 2, 3, 4 }
input = new List<int>() { 1, 2, 3, 4, 5 };
Console.WriteLine(String.Join(',', RotateLeft(rotation, input)));

// ====================================================================

static List<int> RotateLeft(int d, List<int> arr){

    int t = (d / arr.Count);
    if ((arr.Count * t).Equals(d)) return arr;

    if(arr.Count < d){
        int r = (d - (arr.Count * t));
        return RotateLeft(r, arr);
    }

    var _arr = new List<int>(arr.Count);

    _arr.AddRange(arr.Skip(d));
    _arr.AddRange(arr.Take(d));

    return _arr;

}