namespace Maze;

public class StateSpaceTraversal : FutureTree{

    public StateSpaceTraversal(Tree tree, int start, int end)
        : base(tree, start, end) { }

    public override IEnumerable<int>? Find() {
        return null;
    }

}