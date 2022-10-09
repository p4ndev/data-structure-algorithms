
static Node FirstOrDefault(SinglyLinkedList list) => list.Head;

static bool IsEmptyOrNull(SinglyLinkedList list) => list.Head is null;

static Node SingleOrDefault(int data, SinglyLinkedList list) {
    
    if (IsEmptyOrNull(list)) return null;               // Once empty, null
    
    var temp = list.Head;                               // Get first for iteration
    if (temp.Data.Equals(data)) return temp;            // Check if data is present

    while (temp.Next is not null){                      // Iterate
        temp = temp.Next;                                   // Next element
        if (temp.Data.Equals(data))                         // Check if data is present
            return temp;                                        // Once true, return node
    }

    return null;
    
}

static Node LastOrDefault(SinglyLinkedList list) {

    if (IsEmptyOrNull(list)) return null;      // Empty, quickly return null
    
    var temp = list.Head;                      // First element, for iteration

    while (temp.Next is not null)              // Once has next, consider it
        temp = temp.Next;
    
    return temp;                               // It'll return null or the last

}