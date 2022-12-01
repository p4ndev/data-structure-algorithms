public class Node {
    
    public int   Data        { get; set; } = 0;
    public Node? Previous    { get; set; } = null;
    public Node? Next        { get; set; } = null;
    public Node(int data)    => Data = data;

}