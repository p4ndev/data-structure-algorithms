namespace hacker_rank;

internal class Tree{

    public Node? Root { get; set; } = null;

    public Tree Add(int num, ActionType action = ActionType.ROOT) {
        switch (action) {

            case ActionType.ROOT:
                AddRoot(num);
                break;

            case ActionType.LEFT:
                AddLeft(num);
                break;

            case ActionType.RIGHT:
                AddRight(num);
                break;

        }
        return this;
    }

    public Tree Merge(Tree current, ActionType action) {
        if (current.Root is not null){
            switch (action){

                case ActionType.LEFT:
                    MergeLeft(current.Root);
                    break;

                case ActionType.RIGHT:
                    MergeRight(current.Root);
                    break;

            }
        }
        return this;
    }

    public void Traverse(SearchType order) {
        switch (order){

            case SearchType.PRE:
                Root!.Print();
                TraversePre(Root!.Left);
                TraversePre(Root!.Right);
                break;

            case SearchType.IN:
                TraverseIn(Root!.Left);
                Root!.Print();
                TraverseIn(Root!.Right);
                break;

            case SearchType.POST:
                TraversePost(Root!.Left);
                TraversePost(Root!.Right);
                Root!.Print();
                break;

        }
        Console.WriteLine();
    }

    #region Insert

    private void AddRoot(int num) => Root = new Node() { Data = num };
    private void AddLeft(int num) => Root!.Left = new Node() { Data = num };
    private void AddRight(int num) => Root!.Right = new Node() { Data = num };

    #endregion

    #region Merge

    private void MergeLeft(Node node)   => Root!.Left   = node;
    private void MergeRight(Node node)  => Root!.Right  = node;

    #endregion
    
    #region Traverse

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

    #endregion

}