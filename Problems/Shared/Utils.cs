using Xunit;

namespace Problems.Shared;

public static class Utils
{
    public static ListNode? CreateList(params int[] values)
    {
        if (values.Length == 0)
            return null;

        var head = new ListNode(values[0]);
        var current = head;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }

    public static void AssertList(ListNode? head, params int[] expected)
    {
        var current = head;

        foreach (var value in expected)
        {
            Assert.NotNull(current);
            Assert.Equal(value, current!.val);
            current = current.next;
        }

        Assert.Null(current);
    }
}
