public partial class LinkedNodeList<T> {

    private bool Exit() {

        if (IsEmpty()) return true;

        if (Head!.Next is null) {
            Head = Tail = null;
            return true;
        }

        return false;

    }

    public void RemoveFirst(){

        if (Exit()) return;

        Head = Head!.Next;

        Decrement();

    }

    public void RemoveLast(){

        if (Exit()) return;

        Node<T>? prev = null, curr = Head!;

        while (curr is not null){

            if (!curr.HasNext()){
                prev!.Next = null;
                Tail = prev;
                Decrement();
                return;
            }

            prev = curr;
            curr = curr!.Next;

        }

    }

    public void RemoveAt(int index) {

        if (index < 0 || (index + 1) > Count)
            return;

        if (index.Equals(0)) {
            RemoveFirst();
            return;
        }

        if ((index + 1).Equals(Count)) {
            RemoveLast();
            return;
        }

        var previous = FindAt(index - 1);
        var next     = FindAt(index + 1);

        if (previous is not null && next is not null)
        {
            previous.Next = next;
            Decrement();
        }

    }

}