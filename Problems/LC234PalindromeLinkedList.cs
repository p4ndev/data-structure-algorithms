namespace Problems;

public class LC234
{
    public bool IsPalindromeExtraSpace(ListNode head)
    {
        ListNode? slow = head;
        ListNode? fast = head;
        Stack<int> storage = new();

        while (fast != null && fast.next != null)
        {
            storage.Push(slow!.val);
            slow = slow.next;
            fast = fast.next.next;
        }

        if (fast != null)
            slow = slow!.next;

        while (storage.Count > 0)
        {
            if (slow == null || storage.Pop() != slow.val)
                return false;

            slow = slow.next;
        }

        return true;
    }


    public bool IsPalindrome(ListNode head)
    {
        ListNode? slow = head;
        ListNode? fast = head;

        // Find middle
        while (fast != null && fast.next != null)
        {
            slow = slow!.next;
            fast = fast.next.next;
        }

        // Odd length -> skip middle
        if (fast != null)
            slow = slow!.next;

        // Reverse second half
        ListNode? secondHalf = Reverse(slow);

        // Compare
        ListNode? firstHalf = head;

        while (secondHalf != null)
        {
            if (firstHalf!.val != secondHalf.val)
                return false;

            firstHalf = firstHalf.next;
            secondHalf = secondHalf.next;
        }

        return true;
    }

    private ListNode? Reverse(ListNode? head)
    {
        ListNode? prev = null;
        ListNode? current = head;

        while (current != null)
        {
            ListNode? next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}