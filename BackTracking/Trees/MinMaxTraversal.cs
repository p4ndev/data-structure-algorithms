namespace Maze;

public class MinMaxTraversal : FutureTree{

    private Stack<Node> _stk;

    public MinMaxTraversal(Tree tree, int start, int end)
        : base(tree, start, end) {
            _stk = new();
            if(_tree.Root is not null)    
                _stk.Push(_tree.Root);
        }

    #region Comparion

    private bool CanCompareNodes(Node node) {
        
        if (node.Left is not null && node.Right is not null)
            return true;
        
        return false;

    }

    private bool CanMin(Node node)
        => !node.MinVisited && node.Left is not null;

    private bool CanMax(Node node)
        => !node.MaxVisited && node.Right is not null;

    #endregion

    #region Helper

    private Node? GetAnyNode(Node node) {

        if (node.Left is not null) {
            node.MinVisited = true;
            return node.Left;
        }

        if (node.Right is not null) {
            node.MaxVisited = true;
            return node.Right;
        }
        
        return null;

    }

    private Node? GetMaxNode(Node node) {

        if (!CanCompareNodes(node)) return null;

        var leftNumber  = node.Left!.Data;
        var rightNumber = node.Right!.Data;

        if (leftNumber > rightNumber) {
            node.MinVisited = true;
            return node.Left;
        } else {
            node.MaxVisited = true;
            return node.Right;
        }

    }

    private Node? GetMinNode(Node node) {

        if (!CanCompareNodes(node)) return null;

        var leftNumber  = node.Left!.Data;
        var rightNumber = node.Right!.Data;

        if (leftNumber < rightNumber) {
            node.MinVisited = true;
            return node.Left;
        } else {
            node.MaxVisited = true;
            return node.Right;
        }

    }

    private IEnumerable<int>? ExportInverted() {
        int[]? output = null;
        output = new int[_stk.Count];
        for (int i = (output.Length - 1); i >= 0; i--)
            output[i] = _stk.Pop().Data;
        return output;
    }

    #endregion

    public override IEnumerable<int>? Find() {

        Node? previous  = null;
        int? data       = null;
        var current     = _stk.Peek();
        
        while (current is not null) {

            // Min / Max Scenarios (Visited and Node)
            if (!current.MinVisited && current.Left is not null) {

                previous            = current;
                data                = current.Data;
                current             = GetMinNode(current);  
                
            }
            else if (!current.MaxVisited && current.Right is not null) {    
                
                previous            = current;
                data                = current.Data;
                current             = GetMaxNode(current);

            }

            // Once didn't find min / max
            if (current is null && previous is not null)
                if (CanMin(previous) || CanMax(previous))
                    current = GetAnyNode(previous);

            // Has at least one node
            if (current is not null){
                if (!current.Equals(_stk.Peek())){
                    _stk.Push(current);
                    // Reach the end, exit loop
                    if (current.Data.Equals(_end))
                        break;
                } else {
                    // Avoiding to pop same result
                    current = null;
                }
            }

            // Rollback once reach here
            if (current is null && !_end.Equals(data!.Value)) {
                _stk.Pop();
                current = _stk.Peek();
                data    = current.Data;
            }

        }

        return ExportInverted();

    }

}