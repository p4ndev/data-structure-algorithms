namespace Problems;

public class LC141
{
    public bool HasCycleFastSlowPointers(ListNode head)
    {
        ListNode? slow = head;
        ListNode? fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow?.next;
            fast = fast.next.next;

            if (slow == fast)
                return true;
        }

        return false;
    }

    public bool HasCycleNaive(ListNode head)
    {
        HashSet<ListNode> visited = new();
        ListNode? current = head;

        while (current != null)
        {
            if (visited.Contains(current))
                return true;

            visited.Add(current);
            current = current.next;
        }

        return false;
    }
}