namespace Maze;

public class MathSiblingsTraversal : FutureTree{

    private IList<int>? _arr;

    public MathSiblingsTraversal(Tree tree, int start, int end)
        : base(tree, start, end) {
            if (_tree.Root is not null) {
                _arr = new List<int>();
                _arr.Add(_tree.Root.Data);
            }
        }

    #region Comparion
    
    private bool IsValid(Node? node) {

        if (node is null)
            return false;

        return true;

    }

    private bool HasChild(Node? node) {
        
        if (!IsValid(node))
            return false;
        
        if (node!.Category is Categorization.None)
            return false;

        return true;

    }

    #endregion

    #region Business Logic

    // Priority: 2
    private Node? FullNode(Node node){

        if (node.Category is Categorization.Full){

            if (node.Left is not null && node.Left.Category is Categorization.Full)
                return node.Left;

            if (node.Right is not null && node.Right.Category is Categorization.Full)
                return node.Right;

        }

        return HalfNode(node);

    }

    // Priority: 1
    private Node? HalfNode(Node node) {
        
        if (node.Left is not null && node.Left.Category is Categorization.Half)
            return node.Left;

        if (node.Right is not null && node.Right.Category is Categorization.Half)
            return node.Right;

        return NoChildren(node);

    }

    // Priority: 0
    private Node? NoChildren(Node node) {

        if (node.Left is not null && node.Left.Category is Categorization.None)
            return node.Left;

        if (node.Right is not null && node.Right.Category is Categorization.None)
            return node.Right;

        return null;

    }

    #endregion

    public override IEnumerable<int>? Find() {

        if (!HasChild(_tree.Root)) return null;

        var current = FullNode(_tree.Root!) ?? HalfNode(_tree.Root!);

        while (current is not null) {
            _arr!.Add(current!.Data);
            current = FullNode(current);
        }

        return _arr;

    }

}