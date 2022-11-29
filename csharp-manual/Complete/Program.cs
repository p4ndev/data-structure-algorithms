var lnl = new LinkedNodeList<int>();

lnl.AddFirst(10);
lnl.AddLast(20);
lnl.AddLast(30);
// 10 -> 20 -> 30

lnl.AddBefore(15, 20);
lnl.AddAfter(25, 20);
// 10 -> 15 -> 20 -> 25 -> 30

lnl.AddBefore(5, 10);
lnl.AddAfter(35, 30);
// 5 -> 10 -> 15 -> 20 -> 25 -> 30 -> 35

Console.WriteLine("Done...");
