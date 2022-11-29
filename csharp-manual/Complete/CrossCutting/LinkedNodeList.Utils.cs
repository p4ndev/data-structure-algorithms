public partial class LinkedNodeList<T> {

    private void Increment()            => Count++;
    private void Decrement()            => Count--;

    public bool HasPeek()               => Head is not null;
    public bool HasTail()               => Tail is not null;
    
    public bool IsEmpty()               => (!HasPeek() && !HasTail());
    public bool IsOutside(int index)    => ((index < 0) || (index + 1) > Count);

}