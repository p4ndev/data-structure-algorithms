public partial class LinkedNodeList<T> {

    private void Increment() => Count++;
    private void Decrement() => Count--;

    public bool HasPeek() => Head is not null;
    public bool HasTail() => Tail is not null;

}