internal partial class IntegerTree {

    private void TraversePost(Node<int>? node)
    {
        if (node is null) return;
        TraversePost(node.Left);
        TraversePost(node.Right);
        Output!.Add(node.Data);
    }

}