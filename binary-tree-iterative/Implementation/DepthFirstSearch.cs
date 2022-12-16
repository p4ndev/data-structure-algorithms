internal partial class Tree {

    /// <summary>
    /// DFS = Profundidade no primeiro nó, em seguida mesmo conceito nos outros
    /// </summary>
    /// <param name="order">Três tipos principais de modo (Pre, In e Post) Order</param>
    public void DepthFirstSearch(OrderType order) {
        switch (order){

            case OrderType.PRE:
                Root!.Print();
                TraversePre(Root!.Left);
                TraversePre(Root!.Right);
                break;

            case OrderType.IN:
                TraverseIn(Root!.Left);
                Root!.Print();
                TraverseIn(Root!.Right);
                break;

            case OrderType.POST:
                TraversePost(Root!.Left);
                TraversePost(Root!.Right);
                Root!.Print();
                break;

        }
        Console.WriteLine();
    }

    private void TraversePre(Node? node) {
        if (node is null) return;
        node.Print();
        TraversePre(node.Left);
        TraversePre(node.Right);
    }

    private void TraverseIn(Node? node) {
        if (node is null) return;
        TraverseIn(node.Left);
        node.Print();
        TraverseIn(node.Right);
    }

    private void TraversePost(Node? node) {
        if (node is null) return;
        TraversePost(node.Left);
        TraversePost(node.Right);
        node.Print();
    }

}