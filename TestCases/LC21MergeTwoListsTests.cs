namespace LC21;

public class MergeTwoListsTests
{
    private readonly Problems.LC21 _sut;

    // Arrange
    public MergeTwoListsTests()
        => _sut = new();

    [Fact]
    public void Should_Merge_Two_Sorted_Lists()
    {
        // Arrange
        var list1 = CreateList(1, 2, 4);
        var list2 = CreateList(1, 3, 4);

        // Act
        var result = _sut.MergeTwoLists(list1!, list2!);

        // Assert
        AssertList(result, 1, 1, 2, 3, 4, 4);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Return_Empty_When_Both_Lists_Are_Empty()
    {
        // Arrange
        ListNode? list1 = null;
        ListNode? list2 = null;

        // Act
        var result = _sut.MergeTwoLists(list1!, list2!);

        // Assert
        Assert.Null(result);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Return_Second_List_When_First_Is_Empty()
    {
        // Arrange
        ListNode? list1 = null;
        var list2 = CreateList(0);

        // Act
        var result = _sut.MergeTwoLists(list1!, list2);

        // Assert
        AssertList(result, 0);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Return_First_List_When_Second_Is_Empty()
    {
        // Arrange
        var list1 = CreateList(0);
        ListNode? list2 = null;

        // Act
        var result = _sut.MergeTwoLists(list1, list2!);

        // Assert
        AssertList(result, 0);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Merge_When_All_Elements_Of_First_List_Are_Smaller()
    {
        // Arrange
        var list1 = CreateList(1, 2, 3);
        var list2 = CreateList(4, 5, 6);

        // Act
        var result = _sut.MergeTwoLists(list1, list2);

        // Assert
        AssertList(result, 1, 2, 3, 4, 5, 6);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Merge_When_All_Elements_Of_Second_List_Are_Smaller()
    {
        // Arrange
        var list1 = CreateList(4, 5, 6);
        var list2 = CreateList(1, 2, 3);

        // Act
        var result = _sut.MergeTwoLists(list1, list2);

        // Assert
        AssertList(result, 1, 2, 3, 4, 5, 6);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Merge_Lists_With_Duplicate_Values()
    {
        // Arrange
        var list1 = CreateList(1, 1, 2);
        var list2 = CreateList(1, 3);

        // Act
        var result = _sut.MergeTwoLists(list1, list2);

        // Assert
        AssertList(result, 1, 1, 1, 2, 3);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Merge_Lists_With_Negative_Numbers()
    {
        // Arrange
        var list1 = CreateList(-10, -3, 5);
        var list2 = CreateList(-8, 0, 7);

        // Act
        var result = _sut.MergeTwoLists(list1, list2);

        // Assert
        AssertList(result, -10, -8, -3, 0, 5, 7);
    }

    private static ListNode? CreateList(params int[] values)
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

    private static void AssertList(ListNode? head, params int[] expected)
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
