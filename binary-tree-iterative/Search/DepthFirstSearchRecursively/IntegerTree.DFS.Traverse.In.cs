internal partial class IntegerTree {

    private void TraverseIn(Node<int>? node)
    {
        if (node is null) return;
        TraverseIn(node.Left);
        Output!.Add(node.Data);
        TraverseIn(node.Right);
    }

}