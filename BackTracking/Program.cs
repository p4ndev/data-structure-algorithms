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

// Based on children focused on math operation
var mst = new MathSiblingsTraversal(bt, 0, 8);
var re0 = mst.Find();

// Backtracking based on availability
var mmt = new MinMaxTraversal(bt, 0, 8);
var re1 = mmt.Find();

// All possibilities and cases recursively
var sst = new StateTreeTraversal(bt, 0, 8);
var re2 = sst.Find();

Console.WriteLine("Done...");