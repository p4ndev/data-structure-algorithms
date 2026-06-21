public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

/*
using System.Text;

ListNode ReverseList(ListNode head)
{
    ListNode prev = null;
    ListNode curr = head;

    while (curr != null)
    {
        ListNode temp = curr.next;
        curr.next = prev;
        prev = curr;
        curr = temp;
    }

    return prev;
}

ListNode input = new(1);
input.next = new ListNode(2);
input.next.next = new ListNode(3);
input.next.next.next = new ListNode(4);
input.next.next.next.next = new ListNode(5);

ListNode output = ReverseList(input);

var sb = new StringBuilder();

while (output is not null) {
    sb.Append(output.val).Append(" ");
    output = output.next;
}

Console.WriteLine(sb.ToString());
 
*/