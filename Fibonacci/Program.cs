using Fibonacci.Core;
using Fibonacci.Builder;

// =========== Criteria Acceptance ============

// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 => values
// 0, 1, 2, 3, 4, 5, 6,  7,  8,  9 => indexes

// ============== Abstraction =================

var builder = new FibBuilder();

// ============== Implementation ==============

var pureRecursion    = new Common();
var tabNoRecursion   = new Tabulation();
var memoRecursion    = new Memoization();

// ============ Success Execution =============

builder.First(pureRecursion);   //0
builder.First(tabNoRecursion);  //0
builder.First(memoRecursion);   //0

Console.WriteLine();

builder.Seventh(pureRecursion);  //8
builder.Seventh(tabNoRecursion); //8
builder.Seventh(memoRecursion);  //8

Console.WriteLine();

builder.Tenth(pureRecursion);   //34
builder.Tenth(tabNoRecursion);  //34
builder.Tenth(memoRecursion);   //34

Console.WriteLine();

// ============ Fail Execution =============

builder.NegativeSequence(pureRecursion);
builder.NegativeSequence(tabNoRecursion);
builder.NegativeSequence(memoRecursion);

Console.WriteLine();

builder.ExceedSequence(pureRecursion);
builder.ExceedSequence(tabNoRecursion);
builder.ExceedSequence(memoRecursion);