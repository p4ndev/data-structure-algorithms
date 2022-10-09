
var input = new SinglyLinkedListNode(40);
input.next = new SinglyLinkedListNode(30);
input.next.next = new SinglyLinkedListNode(20);
input.next.next.next = new SinglyLinkedListNode(10);

Console.WriteLine(GetNode(input, 2));

static int GetNode(SinglyLinkedListNode llist, int positionFromTail){

    var tail = llist;
    int count = 0;

    while (llist is not null) {
        if (count > positionFromTail)
            tail = tail.next;
        llist = llist.next;
        count++;
    }

    return ((count < positionFromTail) ? 0 : tail.data);

}

class SinglyLinkedListNode{

    public int data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode(int nodeData){
        this.data = nodeData;
        this.next = null;
    }

}

class SinglyLinkedList{

    public SinglyLinkedListNode head;
    public SinglyLinkedListNode tail;

    public SinglyLinkedList(){
        this.head = null;
        this.tail = null;
    }

    public void InsertNode(int nodeData){
        SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);
        if (this.head == null)
            this.head = node;
        else
            this.tail.next = node;
        this.tail = node;
    }

}