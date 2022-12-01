var fak = Enumerable.Range(1, 1000000);
var lnl = new LinkedNodeList<int>();

foreach (int item in fak)
    lnl.AddLast(item * 10);

Console.WriteLine("Hello");