namespace Maze;

public class RegularTraversal : FutureTree{

    private Node? _node;

    public override IEnumerable<int>? Find() => null;

    public RegularTraversal(Tree tree, int start, int end)
        : base(tree, start, end) {
            if (_tree.Root is not null)
                _node = _tree.Root;
        }

    public Node? Find(int term, Node? node = null, bool isExternal = true){

        Node? inner = null;

        if (isExternal)     // First call, we might consider root
            inner = (node is null ? _node : node);
        else                // Otherwise, go straight to the node
            inner = node;

        // Base cases to recursive
        if (inner is null)              return null;
        if (inner.Data.Equals(term))    return inner;

        // Recursion left and right
        Node? tmp = Find(term, inner.Left, false);
        if (tmp is null)
            tmp = Find(term, inner.Right, false);

        return tmp;

    }

}