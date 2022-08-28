LinkedList<string> db = new(new[] {
    "Gustavo", "Henrique", "Barcellos", "Jaques"
});

var bar = db.Find("Jaques");
if (bar is not null) {
    if(bar.Previous is not null) Console.WriteLine("Predecessor: " + bar.Previous.Value);
    if(bar.Next is not null) Console.WriteLine("Successor: " + bar.Next.Value);
}

Console.ReadKey();