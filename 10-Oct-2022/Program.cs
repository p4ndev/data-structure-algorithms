using hacker_rank;

int[] inp = { 10, 5, 1, 7, 40, 50 };
//int[] inp = { 10, 5, 1, 7, 40, 38, 50 };
//int[] inp = { 10, 5, 40, 50 };
//int[] inp = { 10, 40, 50 };
//int[] inp = { 10, 40, 45 };
//int[] inp = { 10, 5, 40 };
//int[] inp = { 10, 5, 7 };
//int[] inp = { 10, 40 };
//int[] inp = { 10, 5 };
//int[] inp = { 5 };

var bst = new BinarySearchTree();

foreach (var n in inp) bst.Insert(n);

Console.WriteLine("Total: " + bst.Count());
Console.WriteLine("Height: " + bst.Level());

bst.PreOrder(); //.InOrder().PostOrder()
Console.WriteLine();

bst.Find(6);
bst.Find(40);
bst.Find(43);

Console.WriteLine("Done...");
