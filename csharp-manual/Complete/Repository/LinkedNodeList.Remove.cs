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

}