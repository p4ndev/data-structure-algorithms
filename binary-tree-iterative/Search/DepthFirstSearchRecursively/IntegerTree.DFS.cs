internal partial class IntegerTree {

    public IList<int> DepthFirstSearchRecursively(OrderTypeEnum executionOrder) {
        Output = new List<int>();

        if (Root is null)
            return Output;

        switch (executionOrder) {

            case OrderTypeEnum.PRE:
                Output.Add(Root!.Data);
                TraversePre(Root!.Left);
                TraversePre(Root!.Right);
                break;

            case OrderTypeEnum.IN:
                TraverseIn(Root!.Left);
                Output.Add(Root!.Data);
                TraverseIn(Root!.Right);
                break;

            case OrderTypeEnum.POST:
                TraversePost(Root!.Left);
                TraversePost(Root!.Right);
                Output.Add(Root!.Data);
                break;

        }

        return Output;
    }

}