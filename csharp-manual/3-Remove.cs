
static void RemoveFirst(SinglyLinkedList list) {    
    if (IsEmptyOrNull(list)) return;        // Once it's empty or null, nothing    
    var first = FirstOrDefault(list);       // Get first
    if (first is not null) {                // When it's present
        var temp = first.Next;              // Get next occurrence
        list.Head = temp;                       // Place next at our new HEAD
        list.Count--;                           // Decrement global element counter
    }
}

static void RemoveLast(SinglyLinkedList list) {
    if (IsEmptyOrNull(list)) return;       // Empty or null, nothing
    var current = FirstOrDefault(list);    // First item for iteration
    while (current is not null){           // Iteration
        if (current.Next.Next is null){         // When current is penultimate
            current.Next = null;                    // Unlink last
            list.Count--;                           // Decrement global element counter
        }
        current = current.Next;                 // Fill next
    }
}

static void RemoveAt(int source, SinglyLinkedList list) {

    var current = SingleOrDefault(source, list);        // Find item as current
    if (current is null) return;

    var child = current.Next;                           // Place next into a child
    if (child is null){
        RemoveLast(list);
        return;
    }

    current.Data = child.Data;                          // Exchange from next to found
    current.Next = child.Next;                          // Unlink child ever
    list.Count--;                                       // Decrement global element counter

}

static void RemoveAll(SinglyLinkedList list) {
    list.Head = null;
    list.Count = 0;
}