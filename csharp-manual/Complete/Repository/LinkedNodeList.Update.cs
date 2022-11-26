public partial class LinkedNodeList<T> {

    // UpdateFirst

    // UpdateLast

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

}