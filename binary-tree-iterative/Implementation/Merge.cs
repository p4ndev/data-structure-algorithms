internal partial class Tree {

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

    private void MergeLeft(Node node)   => Root!.Left   = node;
    private void MergeRight(Node node)  => Root!.Right  = node;

}