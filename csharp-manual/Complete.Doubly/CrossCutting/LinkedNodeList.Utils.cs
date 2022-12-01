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

    public Node? FirstOrDefault() => Head;

    public Node? LastOrDefault() => Tail;

    public Node? SingleOrDefault(int data){
        foreach (Node item in MoveNext())
            if (item.Data.Equals(data))
                return item;
        return null;
    }

    public Node? ElementAt(int index){
        int idx = 0;
        foreach (Node item in MoveNext()) {
            if (idx.Equals(index))
                return item;
            idx++;
        }
        return null;
    }

}