public partial class LinkedNodeList<T>{

    public int           Count      { get; set; }
    private Node<T>?     Head       { get; set; }
    private Node<T>?     Tail       { get; set; }

    public LinkedNodeList() {
        Head = Tail = null;
        Count = 0;
    }

}