public partial class LinkedNodeList{

    public bool Remove(Node entry){

        var prev = entry.Previous;
        var next = entry.Next;

        if (prev is null || next is null) return false;

        prev.Next = next;
        next.Previous = prev;

        entry.Previous = entry.Next = null;

        Count--;
        return true;

    }

    public bool RemoveAll(){
        Head = Tail = null;
        Count = 0;
        return true;
    }

    public bool RemoveFirst(){

        if (Count.Equals(0)) return false;

        var current = Head!;
        var next = current.Next;

        Head = next;

        if (next is not null) next.Previous = null;
        if (current is not null) current.Next = null;

        Count--;
        return true;

    }

    public bool RemoveLast(){

        if (Count.Equals(0)) return false;

        var entry = Tail!;
        var prev = entry.Previous;

        Tail = prev;

        if (entry is not null) entry.Previous = null;
        if (prev is not null) prev!.Next = null;

        Count--;
        return true;

    }

    public bool RemoveAt(int index){

        if (index < 0 || index >= Count) return false;

        if (Count.Equals(1) && (index.Equals(0) || index.Equals(Count - 1)))
            return RemoveAll();

        if (index.Equals(0))
            return RemoveFirst();

        if (index.Equals(Count - 1))
            return RemoveLast();

        int idx = 0;
        foreach (var entry in MoveNext())
        {
            if (idx.Equals(index))
                Remove(entry);
            idx++;
        }

        return false;

    }

}