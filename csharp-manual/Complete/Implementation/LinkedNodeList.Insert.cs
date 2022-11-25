public partial class LinkedNodeList<T> {

    private bool Initialize(T data){

        if (HasPeek() && HasTail()) return false;

        Head = Tail = new Node<T>(data);
        Increment();
        return true;

    }

    public void AddFirst(T data) {
        if (Initialize(data)) return;

        Node<T> newHead = new(data);
        newHead.Next = Head!;
        Head = newHead;

        Increment();
    }

    public void AddLast(T data) {
        if (Initialize(data)) return;

        Node<T> tmp = new(data);
        Tail!.Next = tmp;
        Tail = tmp;

        Increment();
    }

}