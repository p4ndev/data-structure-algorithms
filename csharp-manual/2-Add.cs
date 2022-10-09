
static void AddFirst(int data, SinglyLinkedList list) {
    var temp  = new Node(data);             // Temporary NODE with data initialized
    temp.Next = list.Head;                  // Move entire list as next of temporary NODE
    list.Head = temp;                       // Consider the temporary NODE as our new list
    list.Count++;                           // Increment global element counter
}

static void AddLast(int data, SinglyLinkedList list) {
    
    var temp = new Node(data);              // Temporary node
    if (IsEmptyOrNull(list)){               // Once list empty
        list.Head = temp;                       // Start it
        list.Count++;                           // Increment global element counter
        return;
    }

    var lastNode = LastOrDefault(list);     // Iterate until the end
    lastNode.Next = temp;                   // Consider the temporary as next
    list.Count++;                           // Increment global element counter
    
}

static void AddBefore(int data, int source, SinglyLinkedList list) {

    var current = SingleOrDefault(source, list);    // Find the node based on data

    if (current is not null){                       // Check if found

        var nextChain = current.Next;                   // Store all elements on right
        var temp = new Node(source);                    // Temporary node with current data

        temp.Next    = nextChain;                       // Store all elements on temp
        current.Data = data;                            // Consider new data as prev requested
        current.Next = temp;                            // Swap next elements
        
        list.Count++;                                   // Increment global element counter

    }

}

static void AddAfter(int data, int source, SinglyLinkedList list) {

    var current = SingleOrDefault(source, list);    // Find the node based on data

    if (current is not null) {                      // Check if found
        
        var nextChain = current.Next;                     // Only right elements, except current
        var temp = new Node(data);                        // New item to be inserted (temp)
        
        temp.Next = nextChain;                            // Move rest of elements to the new item (temp) 
        current.Next = temp;                              // Consider the temp our next elements
        
        list.Count++;                                     // Increment global element counter
        
    }
    
}

