internal partial class Node<T>
{
    public bool HasLeft()
        => Left is not null;

    public bool HasRight()
        => Right is not null;

    public bool IsLeaf()
        => !HasLeft() && !HasRight();

}
