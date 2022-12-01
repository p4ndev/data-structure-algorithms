var lst = new LinkedNodeList();

lst.AddFirst(2);
    lst.AddLast(3);
lst.AddFirst(1);
    lst.AddLast(4);
    lst.AddLast(5);

lst.Update(3, 30);

lst.RemoveAt(2);

foreach (Node entry in lst.MoveNext())
    Console.Write(entry.Data + " | ");

Console.WriteLine("\n---------------------");

foreach (Node entry in lst.MovePrevious())
    Console.Write(entry.Data + " | ");

Console.WriteLine("\n---------------------");