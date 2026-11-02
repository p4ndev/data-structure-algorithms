internal partial class IntegerTree {

    public IList<int> DepthFirstSearch(OrderTypeEnum executionOrder) {
        Output = new List<int>();

        if (Root is null)
            return Output;

        switch (executionOrder)
        {
            case OrderTypeEnum.PRE:
                TraversePre();
                break;

            case OrderTypeEnum.IN:
                TraverseIn();
                break;

            case OrderTypeEnum.POST:
                TraversePost();
                break;
        }

        return Output;
    }

}