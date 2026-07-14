namespace Problems;

#pragma warning disable CS8600

public class LC21
{
    private List<int> Accumulator { get; set; } = new();

    private bool MoveNext(Func<bool> condition, ref ListNode? target)
    {
        if (target is null || !condition())
            return false;

        Accumulator.Add(target.val);
        target = target.next;
        return true;
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode output;

        while(list1 is not null || list2 is not null)
        {
            if (MoveNext(() => list1 != null && list2 == null, ref list1!))     continue;
            if (MoveNext(() => list1 == null && list2 != null, ref list2!))     continue;
            if (MoveNext(() => list1.val < list2.val, ref list1!))              continue;
            if (MoveNext(() => list1.val > list2.val, ref list2!))              continue;

            Accumulator.AddRange([list1.val, list2.val]);

            list1 = list1.next;
            list2 = list2.next;
        }

        if (!Accumulator.Any())
            return new ListNode();
   
        output = new(Accumulator.FirstOrDefault());
        ListNode? tmp = output.next;
        
        foreach (int num in Accumulator.Skip(1))
        {
            tmp = new(num);
            tmp = tmp.next;
        }

        return output;
    }
}

#pragma warning restore CS8600