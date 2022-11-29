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

    public void AddAt(T data, int index) {

        if (IsOutside(index))
            return;

        if (index.Equals(0)) {
            AddFirst(data);
            return;
        }
        
        Node<T>? current = FindAt(index);

        if (current is not null) {
            Node<T>? newNode = new(current!.Data!);
            current.Data = data;
            newNode.Next = current.Next;
            current.Next = newNode;

            if ((index + 1).Equals(Count))
                Tail = newNode;

            Increment();
        }

    }

}