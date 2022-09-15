using System.Collections.Generic;
using System.Linq;
using System;

// Giving an array of integers, returns two sub-arrays that have the same sum.

var inp = new int[] { 4, 1, 3, 3, 1, 2 }; // 1, 3, 3, 1
var res = SubArray_With_SameSum(inp);

if (res.HasValue)
    Console.WriteLine(
        "{0}\n{1}",
        String.Join(',', res.Value.Item1),
        String.Join(',', res.Value.Item2)
    );
else
    Console.WriteLine("None");

// ======================== Time: O(n)     Space: O(1) =========================

(IEnumerable<int>, IEnumerable<int>)? SubArray_With_SameSum(int[] inp){

    if (inp.Length.Equals(0) || !(inp.Length % 2).Equals(0))
        return null;

    int sum = inp.Sum();

    if (sum.Equals(0) || !(sum % 2).Equals(0))
        return null;

    int i = 0, j = 0, target = (sum / 2);

    for (i = 0, j = 0; i < inp.Length; i++){
        j += inp[i];
        if (j >= target)
            break;
    }

    j = (i + 1);

    return (
        inp.Take(j),
        inp.Skip(j)
    );

}