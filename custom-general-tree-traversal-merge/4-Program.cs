using hacker_rank;

var _last = new Tree()
    .Add(2)
        .Add(4, ActionType.LEFT)
        .Add(5, ActionType.RIGHT);

// ========================================

var _first = new Tree()
    .Add(1)
        .Merge(_last, ActionType.LEFT)
        .Add(3, ActionType.RIGHT);

// ========================================

//_first.Traverse(SearchType.PRE);
//_first.Traverse(SearchType.IN);
//_first.Traverse(SearchType.POST);

// ========================================

Console.WriteLine("Done...");