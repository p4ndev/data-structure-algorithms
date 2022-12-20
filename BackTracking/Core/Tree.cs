namespace Maze;

public class Tree{

    public int Count { get; private set; }  = 0;
    public Node? Root { get; private set; } = null;

    public void AddRoot(int term)   => Root = Helper.CreateNode(term);
    public void RemoveRoot()        => Root = null;

    public void Increment()         => Count++;
    public void Decrement()         => Count--;

}