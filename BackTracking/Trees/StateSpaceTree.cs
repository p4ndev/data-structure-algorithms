namespace Maze;

public class StateSpaceTree : FutureTree{

    private IList<HashSet<int>>         _graph;
    private int                         _index;
    private int                         _foundAt;

    public StateSpaceTree(Tree tree, int start, int end)
        : base(tree, start, end) {
            _graph      = new List<HashSet<int>>();
            _foundAt    = -1;
            _index      = 0;
            Fill(_tree.Root);
        }

    public override IEnumerable<int>? Find()
        => (_graph is null || _foundAt.Equals(-1)) ?
                null : _graph![_foundAt].ToArray();

    private void Fill(Node? current) {

        #region Base cases, and initialization
        if (current is null) return;
        Node? previous  = null;
        _graph.Add(new());
        #endregion

        while (current is not null) {
            if(current.Left is not null || current.Right is not null)
                previous = current;

            if (current.Data.Equals(_end))
                _foundAt = _index;

            _graph[_index].Add(current.Data);
            current = ((current.Left is not null) ? current.Left : current.Right);
        }

        #region Forest (cut and remove leaves)
        if (previous is not null)
            if (previous.Left is not null){
                previous.RemoveLeft();
                _tree.Decrement();
            } else {
                previous.RemoveRight();
                _tree.Decrement();
            }
        #endregion

        #region Tree still has nodes, or not
        if (_tree.Count >= 2) {
            _index++;
            previous = null;
            Fill(_tree.Root);
        }else{
            _tree.RemoveRoot();
            _tree.Decrement();
        }
        #endregion

    }

}