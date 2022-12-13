using Maze;

var mz = new MazeTree();
var bt = mz.Build();

if (bt.Root is not null) {
    var rt = new RegularTraversal(bt, 0, 8);
    var zero    = rt.Find(0);
    var four    = rt.Find(4);
    var six     = rt.Find(6);
    var eight   = rt.Find(8);
    var twenty  = rt.Find(20);
}

IEnumerable<int>? res;

//var mst = new MathSiblingsTraversal(bt, 0, 8);
//res = mst.Find();
//if (res is not null)
//    Console.WriteLine(String.Join(",", res));

//var mmt = new MinMaxTraversal(bt, 0, 8);
//res = mmt.Find();
//if (res is not null)
//    Console.WriteLine(String.Join(",", res));

//var sst = new StateSpaceTree(bt, 0, 8);
//res = sst.Find();
//if (res is not null)
//    Console.WriteLine(String.Join(",", res));

Console.WriteLine("Done...");