
class Node { // Base
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data) {
        Data = data;
        Next = null;
    }

}

class SinglyLinkedList { // Usage
    public Node Head { get; set; }
    public int Count { get; set; } = 0;

}
