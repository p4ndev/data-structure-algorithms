public partial class LinkedNodeList {

    public IEnumerable<Node> MoveNext() {

        Node? iterator;
        Node data;

        if (Count <= 0) yield break;

        iterator = Head!;
        while (iterator is not null) {
            data     = iterator;
            iterator = iterator.Next;
            yield return data;
        }

    }

    public IEnumerable<Node> MovePrevious() {

        Node? iterator;
        Node data;

        if (Count <= 0) yield break;

        iterator = Tail!;
        while (iterator is not null) {
            data        = iterator;
            iterator    = iterator.Previous;
            yield return data;
        }

    }

}