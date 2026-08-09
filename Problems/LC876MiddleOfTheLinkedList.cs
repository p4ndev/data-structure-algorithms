namespace Problems;

public class LC876
{
    public ListNode MiddleNodeNaive(ListNode head)
    {
        int counter = 0;
        ListNode? current = head;
        
        while (current != null)
        {
            current = current.next;
            counter++;
        }

        current = head;

        for (int i = 0; i < (counter / 2); i++)
            current = current!.next;

        return current!;
    }

    public ListNode MiddleNodeSlowFastPointers(ListNode head)
    {
        ListNode? slow = head;
        ListNode? fast = head;

        while(fast != null && fast.next != null)
        {
            slow = slow!.next;
            fast = fast.next.next;
        }

        return slow!;
    }
}