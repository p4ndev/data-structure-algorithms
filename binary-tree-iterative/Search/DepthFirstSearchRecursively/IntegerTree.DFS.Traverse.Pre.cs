internal partial class IntegerTree {

    private void TraversePre(Node<int>? node)
    {
        if (node is null) return;
        Output!.Add(node.Data);
        TraversePre(node.Left);
        TraversePre(node.Right);
    }

}