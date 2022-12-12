namespace Maze;

public class StateSpaceTree : FutureTree{

    public StateSpaceTree(Tree tree, int start, int end)
        : base(tree, start, end) { }

    public override IEnumerable<int>? Find() {
        return null;
    }

}