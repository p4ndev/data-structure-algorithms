public class SinglyListNode<T>
{
    public T val;

    public SinglyListNode<T>? next;

    public SinglyListNode(T val)
    {
        this.val = val;
        this.next = null;
    }

    public SinglyListNode(T val, SinglyListNode<T> next)
        : this(val)
            => this.next = next;

}