namespace Maze;

public class MinMaxTree : FutureTree{

    public MinMaxTree(Tree tree, int start, int end)
        : base(tree, start, end) { }

    public override IEnumerable<int>? Find() {
        return null;
    }

}