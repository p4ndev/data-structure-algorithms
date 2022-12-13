using Maze;

/* ================= I/P (tree) =================

                0
             /     \
            /       \
           1         3
            \       / \
             2     4   6
                  / \
                 5   7
                      \
                       8

=============== Maze (abstract) ===================

            |------------------------|
  start =>     0       1      2      |
                  -------------------|
            |  3       4      5      |
            |     |        ----------|
            |  6  |    7      8        ===> End
            |-----|------------------|

========================= O/P =====================

    [ 0, 3, 4, 7, 8 ]
    from start to end
    best solution

**************************************************/

var mz = new MazeTree();
var bt = mz.Build();

// Simplest way to find nodes recursively
var rt      = new RegularTraversal(bt, 0, 8);
var zero    = rt.Find(0);
var six     = rt.Find(6);
var twenty  = rt.Find(20);

// Based on children focused on math operation
var mst = new MathSiblingsTraversal(bt, 0, 8);
var re0 = mst.Find();

// Backtracking based on availability
var mmt = new MinMaxTraversal(bt, 0, 8);
var re1 = mmt.Find();

// Every single possibilities first, and then best
var sst = new StateSpaceTree(bt, 0, 8);
var re2 = sst.Find();

Console.WriteLine("Done...");