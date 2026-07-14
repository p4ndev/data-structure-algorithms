namespace Problems;

public class LC206
{
    /*
    1ms Runtime	4,45% Beats	    42 Mb Memory		70% Beats
    https://leetcode.com/problems/reverse-linked-list/submissions/2031106636/ 
    */
    public DoublyListNode<int> ReverseList(DoublyListNode<int> head)
    {
        DoublyListNode<int> initial = head;
        var storage = new Stack<int>();

        while (head is not null)
        {
            storage.Push(head.val);

            if (head is not null)
                head = head.next!;
        }

        head = initial;

        while (initial is not null)
        {
            if (storage.TryPop(out int result))
                initial.val = result;

            if (initial is not null)
                initial = initial.next!;
        }

        return head;
    }
}
