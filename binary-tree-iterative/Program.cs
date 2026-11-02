/*

           1
          / \
         2   3
        / \
       4   5

*/

// =============================================================

var initial = new IntegerTree()
        .Add(2)
            .Add(4, ActionTypeEnum.LEFT)
            .Add(5, ActionTypeEnum.RIGHT);

// =============================================================

var tree = new IntegerTree()
    .Add(1)
        .Merge(initial, ActionTypeEnum.LEFT)
            .Add(3, ActionTypeEnum.RIGHT);

// ==================== BFS - Queue ============================

// tree.BreadthFirstSearch();

// ==================== DFS - Stack ============================

// tree.DepthFirstSearch(OrderTypeEnum.PRE);
// tree.DepthFirstSearchRecursively(OrderTypeEnum.IN);
// tree.DepthFirstSearchRecursively(OrderTypeEnum.POST);

// ==================== DFS - Recursive ========================

// tree.DepthFirstSearchRecursively(OrderTypeEnum.PRE);
// tree.DepthFirstSearchRecursively(OrderTypeEnum.IN);
// tree.DepthFirstSearchRecursively(OrderTypeEnum.POST);
