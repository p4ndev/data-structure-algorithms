namespace LC876;

public class LC876MiddleOfTheLinkedListTests
{
    private readonly Problems.LC876 _sut;

    public LC876MiddleOfTheLinkedListTests()
        => _sut = new();

    [Fact]
    public void Should_Return_Null_When_List_Is_Empty()
    {
        // Act
        var result0 = _sut.MiddleNodeNaive(null);
        var result1 = _sut.MiddleNodeSlowFastPointers(null);

        // Assert
        Assert.Null(result0);
        Assert.Null(result1);
    }

    [Fact]
    public void Should_Return_Single_Node_When_List_Has_One_Node()
    {
        // Arrange
        var node = new ListNode(1);

        // Act
        var result0 = _sut.MiddleNodeNaive(node);
        var result1 = _sut.MiddleNodeNaive(node);

        // Assert
        Assert.Equal(1, result0.val);
        Assert.Equal(1, result1.val);
    }

    [Fact]
    public void Should_Return_Second_Node_When_List_Has_Two_Nodes()
    {
        // Arrange
        var node1 = new ListNode(1);
        var node2 = new ListNode(2);
        node1.next = node2;

        // Act
        var result0 = _sut.MiddleNodeNaive(node1);
        var result1 = _sut.MiddleNodeNaive(node1);

        // Assert
        Assert.Equal(2, result0.val);
        Assert.Equal(2, result1.val);
    }

    [Fact]
    public void Should_Return_Middle_Node_When_List_Has_Odd_Number_Of_Nodes()
    {
        // Arrange
        var node1 = new ListNode(1);
        var node2 = new ListNode(2);
        var node3 = new ListNode(3);
        var node4 = new ListNode(4);
        var node5 = new ListNode(5);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;

        // Act
        var result0 = _sut.MiddleNodeNaive(node1);
        var result1 = _sut.MiddleNodeNaive(node1);

        // Assert
        Assert.Equal(3, result0.val);
        Assert.Equal(3, result1.val);
    }

    [Fact]
    public void Should_Return_Second_Middle_Node_When_List_Has_Even_Number_Of_Nodes()
    {
        // Arrange
        var node1 = new ListNode(1);
        var node2 = new ListNode(2);
        var node3 = new ListNode(3);
        var node4 = new ListNode(4);
        var node5 = new ListNode(5);
        var node6 = new ListNode(6);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;
        node5.next = node6;

        // Act
        var result0 = _sut.MiddleNodeNaive(node1);
        var result1 = _sut.MiddleNodeNaive(node1);

        // Assert
        Assert.Equal(4, result0.val);
        Assert.Equal(4, result1.val);
    }
}