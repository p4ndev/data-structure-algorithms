namespace Maze;

public class StateTreeTraversal : FutureTree{

    private Queue<int> _queue;

    public StateTreeTraversal(Tree tree, int start, int end)
        : base(tree, start, end) => _queue = new();

    private Node? SingleOrDefault(int number, Node? node){

        // Base case for recursion
        if (node is null){
            _queue.Enqueue(-1);
            return null;
        }else
            _queue.Enqueue(node.Data);

        // Base case for search
        if (node.Data.Equals(number))
            return node;

        // Left call
        Node tmp = node!;
        node     = SingleOrDefault(number, node.Left);

        // Right call
        if (node is null)
            node = SingleOrDefault(number, tmp.Right);

        // Export once has it
        return node;

    }

    public override IEnumerable<int>? Find(){
        SingleOrDefault(_end, _tree.Root);
        return _queue.Count.Equals(0) ? null : _queue.ToArray<int>();
    }

}