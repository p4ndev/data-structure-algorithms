public partial class Node<T> {

    public bool HasData() => Data is not null;

    public bool HasNext() => Next is not null;

    public bool IsEqual(T input){
        if (!HasData()) return false;
        if (Data!.Equals(input)) return true;
        return false;
    }

}