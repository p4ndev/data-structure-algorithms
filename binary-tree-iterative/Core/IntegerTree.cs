internal partial class IntegerTree{

    private Queue<Node<int>>?   _queue            = null;
    private Stack<Node<int>>?   _stack            = null;
    private Node<int>?          _tmp              = null;

    public Node<int>? Root { get; set; }        = null;

    private IList<int>? Output { get; set; }    = null;

}