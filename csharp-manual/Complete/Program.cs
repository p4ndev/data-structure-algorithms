var lnl = new LinkedNodeList<int>();

lnl.AddLast(20);
lnl.AddLast(30);
lnl.AddFirst(10);
lnl.AddLast(40);
lnl.AddLast(50);

var record = lnl.Find(40);
Console.WriteLine("Found at index: " + record.Index);