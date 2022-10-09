var fou = 5;
var inp = new List<int>() { 1, 3, 6, 9, 12, 15 };

Console.WriteLine(NativeBinarySearch(inp, fou));
Console.WriteLine(IterativeBinarySearch(inp, fou));
Console.WriteLine(RecursiveBinarySearch(inp, fou, 0, (inp.Count - 1)));

// ================================ Binary search native ================================

int NativeBinarySearch(IList<int> data, int num){
    var result = Array.BinarySearch(data.ToArray(), num);
    return result < 0 ? -1 : result;
}

// ================================ Binary search iterative ================================

int IterativeBinarySearch(IList<int> data, int num) {    
    int min = 0, max = (data.Count - 1);
    while (min <= max) {
        int mid = ((min + max) / 2);
        if (num.Equals(data[mid]))
            return mid;
        else if (num < data[mid])
            max = mid - 1;
        else
            min = mid + 1;
    }
    return -1;
}

// ================================ Binary search recursive ================================

int RecursiveBinarySearch(IList<int> data, int num, int min, int max) {
    if (min <= max){
        int mid = ((min + max) / 2);
        if (num.Equals(data[mid]))
            return mid;
        else if (num < data[mid])
            return RecursiveBinarySearch(data, num, min, mid - 1);
        else
            return RecursiveBinarySearch(data, num, mid + 1, max);
    }
    return -1;    
}

// ============================ Binary search and sort (Tree) ==============================

public static class BinarySearchTreeSorter {

    // Unbalanced binary search tree sort
    public static void UnbalancedBSTSort<T>(this List<T> collection) where T : IComparable<T> {

        if (collection.Count == 0) return;
        Node<T> treeRoot = new Node<T>() { Value = collection[0] };

        for (int i = 1; i < collection.Count; ++i){ // Get a handle on root

            var currentNode = treeRoot;
            var newNode = new Node<T>() { Value = collection[i] };

            while (true) {                
                if (newNode.Value.IsLessThan<T>(currentNode.Value)) { // Go left

                    if (currentNode.Left == null){
                        newNode.Parent = currentNode;
                        currentNode.Left = newNode;
                        break;
                    }
                    currentNode = currentNode.Left;

                }else{ // Go right

                    if (currentNode.Right == null){
                        newNode.Parent = currentNode;
                        currentNode.Right = newNode;
                        break;
                    }
                    currentNode = currentNode.Right;

                }
            }
        }

        // Reference handle to root again
        collection.Clear();
        var treeRootReference = treeRoot;
        _inOrderTravelAndAdd(treeRootReference, ref collection);
        treeRootReference = treeRoot = null;

    }

    // Used to travel a node's subtrees and add the elements to the collection
    private static void _inOrderTravelAndAdd<T>(Node<T> currentNode, ref List<T> collection) where T : IComparable<T>{
        if (currentNode == null) return;
        _inOrderTravelAndAdd<T>(currentNode.Left, ref collection);
        collection.Add(currentNode.Value);
        _inOrderTravelAndAdd<T>(currentNode.Right, ref collection);
    }

    // Minimal BST Node class, used only for unbalanced binary search tree sort
    private class Node<T> : IComparable<Node<T>> where T : IComparable<T> {
        
        public T Value { get; set; }
        public Node<T> Parent { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node() {
            Value = default(T);
            Parent = null;
            Left = null;
            Right = null;
        }

        public int CompareTo(Node<T> other){
            if (other == null) return -1;
            return this.Value.CompareTo(other.Value);
        }

    }

}