var last = new Tree()
                    .Add(2)
                        .Add(4, ActionType.LEFT)
                        .Add(5, ActionType.RIGHT);

// =================================================

var first = new Tree()
    .Add(1)
        .Merge(last, ActionType.LEFT)
        .Add(3, ActionType.RIGHT);

// =================================================

//first.DepthFirstSearch(OrderType.PRE);
//first.DepthFirstSearch(OrderType.IN);
//first.DepthFirstSearch(OrderType.POST);

first.BreadthFirstSearch();