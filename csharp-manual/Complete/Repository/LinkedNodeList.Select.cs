public partial class LinkedNodeList<T> {

    public Node<T>? First() => HasPeek() ? Head! : null;

    public Node<T>? Last() => HasTail() ? Tail! : null;

    public (Node<T>? Item, int Index) Find(T data) {
        if (HasPeek()) {
            int idx = 0;
            Node<T>? iterator = Head!;
            while (iterator is not null){
                if (iterator.IsEqual(data))
                    return (iterator, idx);
                iterator = iterator.Next;
                idx++;
            }
        }
        return (null, -1);
    }

}