namespace Maze;

public abstract class FutureTree{

    protected readonly int    _start;
    protected readonly Tree   _tree;
    protected readonly int    _end;

    public FutureTree(Tree tree, int start, int end){
        _start  = start;
        _tree   = tree;
        _end    = end;
    }

    public abstract IEnumerable<int>? Find();

}
