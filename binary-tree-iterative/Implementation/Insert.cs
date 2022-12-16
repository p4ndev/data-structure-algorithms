internal partial class Tree {

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

    private void AddRoot(int num)   => Root         = new(num);
    private void AddLeft(int num)   => Root!.Left   = new(num);
    private void AddRight(int num)  => Root!.Right  = new(num);

}