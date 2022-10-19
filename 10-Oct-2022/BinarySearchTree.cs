namespace hacker_rank;

public class BinarySearchTree{

    private int     Length;
    private Node?   Root;
    
    public BinarySearchTree() => Root = null;

    #region Implementation

    public bool Insert(int number) {

        if (Root is null) {
            Root = new Node(number);
            Length++;
            return true;
        }

        if (Root!.Data.Equals(number))
            return false;

        var current = Root;

        while (current is not null) {
            if (number < current.Data){ // Left attribution
                if (current.Left is null) {
                    current.Left = new Node(number);
                    Length++;
                    return true;
                }
                current = current.Left;
            }else if (number > current.Data) {  // Right attribution
                if (current.Right is null) {
                    current.Right = new Node(number);
                    Length++;
                    return true;
                }
                current = current.Right;
            }
        }

        return false;

    }

    private void Traverse(Node? node, TraverseType mode) {

        if (node is null) return;

        switch (mode) {

            default:
            case TraverseType.Pre:
                Console.Write(node.Data + " ");
                Traverse(node.Left, mode);
                Traverse(node.Right, mode);
                break;

            case TraverseType.In:
                Traverse(node.Left, mode);
                Console.Write(node.Data + " ");
                Traverse(node.Right, mode);
                break;

            case TraverseType.Post:
                Traverse(node.Left, mode);
                Traverse(node.Right, mode);
                Console.Write(node.Data + " ");
                break;

        }
        
    }

    private int NavigateTo(Node? node, SearchSide type) {
        if (node is null) return 0;
        
        int output = 0;

        if (type.Equals(SearchSide.Left)){
            
            output = NavigateTo(node.Left, type);            
            if (node.Left is null && node.Right is not null)
                output++;

        } else {
            
            output = NavigateTo(node.Right, type);            
            if (node.Right is null && node.Left is not null)
                output++;

        }

        return output;
    }

    private IList<int> Search(int number, Node? node) {
        if (node is not null && node.Data.HasValue) {
            
            var arr = new List<int>();
            arr.Add(node.Data.Value);
            
            if (arr[0].Equals(number))
                return arr;

            arr.AddRange(
                Search(
                    number, (
                    number < arr[0] ?
                        node.Left : node.Right
                    )
                )
            );

            return arr;

        }
        return Array.Empty<int>();
    }

    #endregion

    #region Entrypoint
    
    public void Find(int data) {
        var result = Search(data, Root);

        if (result.LastOrDefault().Equals(data)){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Successfully :)\nseached in {0} steps [{1}]", result.Count, String.Join(' ', result));
        }else{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed :(\nafter {0} steps [{1}]", result.Count, String.Join(' ', result));
        }

        Console.ForegroundColor = ConsoleColor.White;
    }

    public int Level() {

        if (Length <= 2) // Binary concept (corner)
            return Length.Equals(0) ? -1 : Length;

        int level = -1;

        if (Root is not null) {

            int left  = NavigateTo(Root.Left, SearchSide.Left);
            int right = NavigateTo(Root.Right, SearchSide.Right);

            if (left.Equals(right)) level = left + 1;
            if (left.Equals(0))     level = right;
            if (right.Equals(0))    level = left;

            level = (left > right ? left : right) + 1;

        }

        return level;

    }

    public int Count()      => Length;
    
    public void PreOrder()  => Traverse(Root, TraverseType.Pre);

    public void InOrder()   => Traverse(Root, TraverseType.In);

    public void PostOrder() => Traverse(Root, TraverseType.Post);

    #endregion

}