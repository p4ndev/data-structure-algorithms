namespace hacker_rank;

public class Node{

    public int?  Data       { get; set; }
    public Node()           => Data = null;
    public Node(int data)   => Data = data;

    public Node? Left       { get; set; } = null;
    public Node? Right      { get; set; } = null;

}