var pro = System.Diagnostics.Process.GetCurrentProcess();
var stp = new System.Diagnostics.Stopwatch();
var fak = Enumerable.Range(1, 5);
var lnl = new LinkedNodeList<int>();

foreach (int item in fak)
    lnl.AddLast(item * 10);

stp.Start();
lnl.Reverse();
stp.Stop();

Console.WriteLine(
    "{0} ms with {1} nodes | Memory: {2} kb",
    stp.Elapsed.TotalMilliseconds,
    lnl.Count,
    (pro.PrivateMemorySize64 / 1024)
);