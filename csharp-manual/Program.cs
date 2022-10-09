using System.Text.Json;

var _chain = new SinglyLinkedList();

AddLast(40, _chain);
AddFirst(20, _chain);
AddBefore(10, 20, _chain);
AddAfter(30, 20, _chain);
AddLast(50, _chain);

RemoveFirst(_chain);
RemoveAt(30, _chain);
RemoveLast(_chain);
RemoveAll(_chain);

Console.WriteLine("Element(s): " + _chain.Count);
Console.WriteLine("-------------------------------");

Console.WriteLine(
    JsonSerializer.Serialize(
        _chain.Head,
        new JsonSerializerOptions {
            WriteIndented = true
        }
    )
);

Console.WriteLine("-------------------------------");

