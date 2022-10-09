var fou = 5;
var inp = new List<int>() { 1, 3, 6, 9, 12, 15 };

Console.WriteLine(NativeBinarySearch(inp, fou));
Console.WriteLine(IterativeBinarySearch(inp, fou));
Console.WriteLine(RecursiveBinarySearch(inp, fou, 0, (inp.Count - 1)));

int NativeBinarySearch(IList<int> data, int num){

    var result = Array.BinarySearch(data.ToArray(), num);

    return result < 0 ? -1 : result;

}

int IterativeBinarySearch(IList<int> data, int num) {
    
    int min = 0, max = (data.Count - 1);

    while (min <= max) {

        int mid = ((min + max) / 2);

        if (num.Equals(data[mid]))
            return mid;
        else if (num < data[mid])
            max = mid - 1;
        else
            min = mid + 1;

    }

    return -1;

}

int RecursiveBinarySearch(IList<int> data, int num, int min, int max) {

    if (min <= max){

        int mid = ((min + max) / 2);

        if (num.Equals(data[mid]))
            return mid;
        else if (num < data[mid])
            return RecursiveBinarySearch(data, num, min, mid - 1);
        else
            return RecursiveBinarySearch(data, num, mid + 1, max);

    }

    return -1;
    
}
