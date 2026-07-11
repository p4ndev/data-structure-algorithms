public class ListNode<T>
{
    public T val;
    public int idx;

    public ListNode<T>? next;
    public ListNode<T>? previous;

    public ListNode(T val)
    {
        this.val = val;
        this.idx = 0;

        this.previous = null;
        this.next = null;
    }

    public ListNode(T val, int idx)
        : this(val)
            => this.idx = idx;

    public ListNode(T val, int idx, ListNode<T> previous)
        : this(val, idx)
            => this.previous = previous;

    public ListNode(T val, int idx, ListNode<T> previous, ListNode<T> next)
        : this(val, idx, previous)
            => this.next = next;
}