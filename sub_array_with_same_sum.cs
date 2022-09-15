
// Giving an array of integers, returns two sub-arrays
// that have the same sum (possible partitioned)

// Wors problem ever from Exponent Youtube Channel :(

var inp = new List<int> { 1, 3, 2, 2, 3, 1 };
//var inp = new List<int> { 1, 3, 2, 3, 2, 1 };
//var inp = new List<int> { 2, 1, 3, 2, 1, 3 };
//var inp = new List<int> { 0, 0, 0, 0, 0, 0 };
//var inp = new List<int> { 2, 1, 3, 1 };
//var inp = new List<int> { 2, 1, 3 };
//var inp = new List<int>();

var res = SubArray_With_SameSum_v1(inp);

if (res.HasValue)
    Console.WriteLine(
        "{0}\n{1}",
        String.Join(',', res.Value.Item1),
        String.Join(',', res.Value.Item2)
    );
else
    Console.WriteLine("None");

(IList<int>, IList<int>)? SubArray_With_Same_Sum_v2(List<int> a){

    if (a.Count.Equals(0) || !(a.Count % 2).Equals(0)) return null;

    int s = a.Sum();

    if (s.Equals(0) || !(s % 2).Equals(0)) return null;

    int t = (s / 2);
    int c = (a.Count / 2);
    var _a = new List<int>(c);

    for (int i = 0; i < a.Count; i++) {

        if (a[i] <= t) {
            t -= a[i];
            _a.Add(a[i]);
            a.RemoveAt(i);
            i--;
        }

        if (_a.Count >= c) break;

    }

    return (a, _a);

}

(IEnumerable<int>, IEnumerable<int>)? SubArray_With_SameSum_v1(List<int> a){

    int c = a.Count;

    if (c.Equals(0) || !(c % 2).Equals(0))
        return null;

    int s = a.Sum();

    if (s.Equals(0) || !(s % 2).Equals(0))
        return null;

    int i, j, t = (s / 2);

    for (i = 0, j = 0; i < c; i++){
        j += a[i];
        if (j >= t)
            break;
    }

    j = (i + 1);

    return (
        a.Take(j),
        a.Skip(j)
    );

}