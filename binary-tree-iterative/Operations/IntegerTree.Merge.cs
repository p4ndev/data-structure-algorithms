internal partial class IntegerTree {

    public IntegerTree Merge(IntegerTree current, ActionTypeEnum action) {

        if (current.Root is null)
            return this;

        switch (action){

            case ActionTypeEnum.LEFT:
                Root!.Left = current.Root;
                break;

            case ActionTypeEnum.RIGHT:
                Root!.Right = current.Root;
                break;

        }
        
        return this;
    }

}