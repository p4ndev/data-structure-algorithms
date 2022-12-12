using Maze;

var mz = new MazeTree();
var bt = mz.Build();

if (bt.Root is not null) {
    var zero    = bt.Find(0, bt.Root);
    var four    = bt.Find(4, bt.Root);
    var six     = bt.Find(6, bt.Root);
    var eight   = bt.Find(8, bt.Root);
    var twenty  = bt.Find(20, bt.Root);
}

var mst = new MathSiblingsTraversal(bt, 0, 8);
var result = mst.Find();
if (result is not null)
    Console.WriteLine(String.Join(",", result));

//var mmt = new MinMaxTree(bt, 0, 8);
//result = mmt.Find();
//if(result is not null)
//    Console.WriteLine(String.Join(",", result));

//var sst = new StateSpaceTree(bt, 0, 8);
//result = sst.Find();
//if (result is not null)
//    Console.WriteLine(String.Join(",", result));

Console.WriteLine("Done...");