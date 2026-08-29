/*
    t       =>      total
    ms      =>      max sum
    ws      =>      window sum
    tb      =>      total block
    a       =>      input array
    k       =>      window size
    cs      =>      current sum
    xs      =>      extra storage
    r...    =>      integer results
*/

// O/P (Expected): 6
int[] a = { 5, 2, -1, 0, 3 };
int k = 3;

// O/P (Expected): 700
//int[] a = { 100, 200, 300, 400 };
//int k = 2;

// O/P (Expected): 39
//int[] a = { 1, 4, 2, 10, 23, 3, 1, 0, 20 };
//int k = 4;

// O/P (Expected): 400
//int[] a = { 100, 200, 300, 400 };
//int k = 1;

int r0 = MaxSumNaive.Extract(a, k);
int r1 = MaxSumNaiveLinq.Extract(a, k);
int r2 = MaxSumExtraSpaceLinq.Extract(a, k);
int r3 = MaxSumSliddingWindowBest.Extract(a, k);

Console.WriteLine("MaxSumNaive: {0}", r0);
Console.WriteLine("MaxSumNaiveLinq: {0}", r1);
Console.WriteLine("MaxSumExtraSpaceLinq: {0}", r2);
Console.WriteLine("MaxSumSliddingWindowBest: {0}", r3);
