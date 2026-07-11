namespace Problems.LC1472;

public class DoublyLinkedListNative
{
    private readonly LinkedList<string> _history;
    private LinkedListNode<string> _current;

    public DoublyLinkedListNative(string homepage)
    {
        if (string.IsNullOrWhiteSpace(homepage))
            throw new ArgumentException("Please provide a valid homepage.");

        _history = new LinkedList<string>();
        _current = _history.AddFirst(homepage);
    }

    public void Visit(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
            throw new ArgumentException("Please provide a valid url.");

        while (_current.Next != null)
            _history.RemoveLast();

        _current = _history.AddAfter(_current, url);
    }

    public string Back(int steps)
    {
        if (steps < 0)
            steps = -steps;

        while (steps > 0 && _current.Previous != null)
        {
            _current = _current.Previous;
            steps--;
        }

        return _current.Value;
    }

    public string Forward(int steps)
    {
        if (steps < 0)
            steps = -steps;

        while (steps > 0 && _current.Next != null)
        {
            _current = _current.Next;
            steps--;
        }

        return _current.Value;
    }
}