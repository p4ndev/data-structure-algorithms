using System.Text.Json;
var _chain = new LinkedList<int>(new []{ 20, 40 });

// ==================================================================================================================

_chain.AddFirst(10);
_chain.AddLast(60);

// ==================================================================================================================

LinkedListNode<int>? thirty = _chain.Find(20);
if(thirty is not null) _chain.AddAfter(thirty, 30);

LinkedListNode<int>? fifty = _chain.Find(60);
if (fifty is not null) _chain.AddBefore(fifty, 50);

// ==================================================================================================================

var first = _chain.First;
if(first is not null) Console.WriteLine("First: " + first.Value);

var last = _chain.Last;
if(last is not null) Console.WriteLine("Last: " + last.Value);

// ==================================================================================================================

_chain.RemoveFirst();
_chain.RemoveLast();
_chain.Remove(60);

// ==================================================================================================================

Console.WriteLine("Count: " + _chain.Count);
Console.WriteLine("-------------------------------");

Console.WriteLine(
    JsonSerializer.Serialize(
        _chain,
        new JsonSerializerOptions {
            WriteIndented = true
        }
    )
);
Console.WriteLine("-------------------------------");