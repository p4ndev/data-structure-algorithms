public class DoublyListNode<T>
{
    public T val;
    public int idx;

    public DoublyListNode<T>? next;
    public DoublyListNode<T>? previous;

    public DoublyListNode(T val)
    {
        this.val = val;
        this.idx = 0;

        this.previous = null;
        this.next = null;
    }

    public DoublyListNode(T val, int idx)
        : this(val)
            => this.idx = idx;

    public DoublyListNode(T val, int idx, DoublyListNode<T> previous)
        : this(val, idx)
            => this.previous = previous;

    public DoublyListNode(T val, int idx, DoublyListNode<T> previous, DoublyListNode<T> next)
        : this(val, idx, previous)
            => this.next = next;
}