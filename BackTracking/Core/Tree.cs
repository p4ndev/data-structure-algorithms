namespace Maze;

public class Tree{

    public Node? Root { get; private set; }

    public void AddRoot(int term) => Root = Helper.CreateNode(term);

    public Node? Find(int term, Node? node) {

        if (node is null)           return null;
        if (node.Data.Equals(term)) return node;

        Node? tmp = Find(term, node.Left);

        if (tmp is null)
            tmp = Find(term, node.Right);

        return tmp;

    }

}