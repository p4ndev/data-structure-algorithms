namespace Problems;

public class LC2
{
    public DoublyListNode<int> AddTwoNumbers(DoublyListNode<int> l1, DoublyListNode<int> l2)
    {
        DoublyListNode<int>? data = null;
        DoublyListNode<int>? output = data;
        int carry = 0, rest = 0, total = 0, leftNum = 0, rightNum = 0;

        while (l1 is not null || l2 is not null)
        {

            leftNum = l1 is not null ? l1.val : 0;
            rightNum = l2 is not null ? l2.val : 0;

            total = (leftNum + rightNum + carry);

            if (total >= 10)
            {
                carry = (total / 10);
                rest = (total % 10);
                total = rest;
            }
            else
                carry = 0;

            if (data is null)
            {
                data = new(total);
                output = data;
            }
            else
            {
                data.next = new(total);
                data = data.next;
            }

            if (l1 is not null) l1 = l1.next;
            if (l2 is not null) l2 = l2.next;

        }

        if (carry > 0)
            data!.next = new(carry);

        return output!;
    }
}
