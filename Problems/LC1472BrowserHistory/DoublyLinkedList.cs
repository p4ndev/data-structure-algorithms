namespace Problems.LC1472;

/* 
6ms Runtime 68% Beats               63Mb Memory 53% Beats
https://leetcode.com/problems/design-browser-history/submissions/2064212351 
*/

public class DoublyLinkedList
{
    private int _idx;
    private int _total;
    private int _available;

    private DoublyListNode<string> _current;
    private DoublyListNode<string> _head, _tail;

    public DoublyLinkedList(string homepage)
    {
        if (String.IsNullOrWhiteSpace(homepage))
            throw new ArgumentException("Please provide a valid homepage");

        DoublyListNode<string> storage = new(homepage);
        
        _total = 1;
        _idx = _available = 0;
        _current = _head = _tail = storage;
    }

    public void Visit(string url)
    {
        if (String.IsNullOrWhiteSpace(url))
            throw new ArgumentException("Please provide a valid url");

        int nextIndex = (_current.next is null ? (_idx + 1) : _current.next.idx);
        var node = new DoublyListNode<string>(url, nextIndex);

        _idx = nextIndex;
        _total = (_idx + 1);

        node.previous = _current;
        _current.next = node;

        _tail = _current.next;
        _current = _tail;
    }

    public string Back(int steps)
    {
        if (steps < 0)
            steps *= -1;

        if (steps >= _idx) {
            _current = _head;
            _idx = 0;
        }
        else
            while (steps > 0)
            {
                _idx--;
                steps--;
                _current = _current.previous!;
            }

        return _current.val;
    }

    public string Forward(int steps)
    {
        if (steps < 0)
            steps *= -1;

        _available = ((_total - _idx) - 1);

        if(steps >= _available)
        {
            _current = _tail;
            _idx = (_total - 1);
        }
        else
            while (steps > 0)
            {
                steps--;
                _idx++;
                _current = _current.next!;
            }

        return _current.val;
    }
}