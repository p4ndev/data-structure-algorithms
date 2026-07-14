namespace Problems;

#pragma warning disable CS8600

/*
2ms Runtime 5.45% Beats                 45.07Mb Memory 8.05% Beats
https://leetcode.com/problems/merge-two-sorted-lists/submissions/2067438652
*/

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
        ListNode? output = null, aux = null;

        if (list1 is null && list2 is null)
            return output;

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
            return output;

        foreach (int num in Accumulator)
        {
            if(output is null)
            {
                output = new(num);
                aux = output;
                continue;
            }

            aux.next = new(num);
            aux = aux.next;
        }

        return output!;
    }
}

#pragma warning restore CS8600