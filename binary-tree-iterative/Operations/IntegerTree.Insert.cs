internal partial class IntegerTree {

    public IntegerTree Add(int num, ActionTypeEnum action = ActionTypeEnum.ROOT) {
        switch (action) {

            case ActionTypeEnum.ROOT:
                Root = new(num);
                break;

            case ActionTypeEnum.LEFT:
                Root!.Left = new(num);
                break;

            case ActionTypeEnum.RIGHT:
                Root!.Right = new(num);
                break;

        }

        return this;
    }

}