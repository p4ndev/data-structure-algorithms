```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.22000.2538/21H2/SunValley)
Intel Core i7-3770 CPU 3.40GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 9.0.0 (9.0.0, 9.0.24.52809), X64 RyuJIT x86-64-v2
  DefaultJob : .NET 9.0.0 (9.0.0, 9.0.24.52809), X64 RyuJIT x86-64-v2


```
| Method          | Mean        | Error     | StdDev    |
|---------------- |------------:|----------:|----------:|
| Naive           |  3,252.0 ns |  64.83 ns |  63.67 ns |
| Linq_Naive      | 23,010.8 ns | 446.20 ns | 495.95 ns |
| Monotomic_Stack |    535.0 ns |  10.56 ns |  15.48 ns |
