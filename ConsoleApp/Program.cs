Node Insert(Node root, int value)
{
    if (root == null)
        return new Node(value);

    if (value < root.data)
        root.left = Insert(root.left, value);
    else
        root.right = Insert(root.right, value);

    return root;
}

Node Lca(Node root, int v1, int v2)
{
    if (root == null)
        return null;

    if (v1 < root.data && v2 < root.data)
        return Lca(root.left, v1, v2);

    if (v1 > root.data && v2 > root.data)
        return Lca(root.right, v1, v2);

    return root;
}

#region Execution
int n = int.Parse(Console.ReadLine());
Node root = null;

foreach (string value in Console.ReadLine().Split(' '))
    root = Insert(root, int.Parse(value));

string[] values = Console.ReadLine().Split(' ');

int v1 = int.Parse(values[0]);
int v2 = int.Parse(values[1]);

Node result = Lca(root, v1, v2);

Console.WriteLine(result.data);
#endregion

#region Test cases
/*

Input: 
6
4 2 3 1 7 6
1 7

Output: 4

*/

/*

Input: 
2
1 2
1 2

Output: 1

*/

/*

Input: 
7
5 3 8 2 4 6 7
7 3

Output: 5

*/

/*

Input: 
9
8 6 5 7 11 12 13 10 9
9 12

Output: 11

*/
#endregion
