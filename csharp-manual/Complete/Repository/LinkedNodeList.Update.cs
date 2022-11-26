public partial class LinkedNodeList<T> {

    public bool UpdateFirst(T data) {
        
        if (Head is not null && !Head.IsEmpty()) {
            Head!.Data = data;
            return true;
        }

        return false;

    }

    public bool UpdateLast(T data) {

        if (Tail is not null && !Tail.IsEmpty()){
            Tail!.Data = data;
            return true;
        }

        return false;

    }

    public bool Update(T from, T to) {
        bool output = false;
        if (HasPeek()) {
            var iterator = Head!;
            while (iterator is not null) {
                if (iterator.IsEqual(from)) {
                    iterator.Data = to;
                    output        = true;
                }
                iterator = iterator.Next;
            }
        }
        return output;
    }

    public bool UpdateAt(T data, int index) {
        bool output = false;

        if (HasPeek()) {
            Node<T>? iterator = Head!;
            while (iterator is not null) {

                if (index.Equals(0)){
                    iterator.Data = data;
                    output = true;
                    break;
                }

                iterator = iterator.Next;
                index--;

            }
        }

        return output;
    }

}