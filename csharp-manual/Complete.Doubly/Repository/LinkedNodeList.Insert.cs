public partial class LinkedNodeList {

    private bool Initialize(int data) {

        if (Head is null && Tail is null) {
            Head = Tail = new Node(data);
            Count++;
            return true;
        }

        return false;

    }

    public void AddFirst(int data) {

        if (Initialize(data)) return;        
        if (Head is null) return;

        var tmp = new Node(data);
        Head!.Previous = tmp;
        tmp.Next = Head!;

        Head = tmp;
        Count++;

    }

    public void AddLast(int data) {

        if (Initialize(data)) return;
        if (Tail is null) return;

        var tmp = new Node(data);
        tmp.Previous = Tail!;
        Tail.Next = tmp;

        Tail = tmp;
        Count++;

    }

}