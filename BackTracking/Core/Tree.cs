namespace Maze;

public class Tree{

    public Node? Root { get; private set; }

    public void AddRoot(int term) => Root = Helper.CreateNode(term);

}