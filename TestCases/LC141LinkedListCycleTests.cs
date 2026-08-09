namespace LC141;

public class LC141LinkedListCycleTests
{
    private readonly Problems.LC141 _sut;

    public LC141LinkedListCycleTests()
        => _sut = new();

    [Fact]
    public void Should_Return_False_When_List_Is_Empty()
    {
        // Act
        var result0 = _sut.HasCycleNaive(null);
        var result1 = _sut.HasCycleFastSlowPointers(null);

        // Assert
        Assert.False(result0);
        Assert.False(result1);
    }

    [Fact]
    public void Should_Return_False_When_List_Has_One_Node()
    {
        // Arrange
        var node = new ListNode(1);

        // Act
        var result0 = _sut.HasCycleNaive(node);
        var result1 = _sut.HasCycleFastSlowPointers(node);

        // Assert
        Assert.False(result0);
        Assert.False(result1);
    }

    [Fact]
    public void Should_Return_True_When_Node_Points_To_Itself()
    {
        // Arrange
        var node = new ListNode(1);
        node.next = node;

        // Act
        var result0 = _sut.HasCycleNaive(node);
        var result1 = _sut.HasCycleFastSlowPointers(node);

        // Assert
        Assert.True(result0);
        Assert.True(result1);
    }

    [Fact]
    public void Should_Return_True_When_List_Has_Cycle()
    {
        // Arrange
        var node1 = new ListNode(3);
        var node2 = new ListNode(2);
        var node3 = new ListNode(0);
        var node4 = new ListNode(-4);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node2;

        // Act
        var result0 = _sut.HasCycleNaive(node1);
        var result1 = _sut.HasCycleFastSlowPointers(node1);

        // Assert
        Assert.True(result0);
        Assert.True(result1);
    }

    [Fact]
    public void Should_Return_False_When_List_Has_No_Cycle()
    {
        // Arrange
        var node1 = new ListNode(1);
        var node2 = new ListNode(2);

        node1.next = node2;

        // Act
        var result0 = _sut.HasCycleNaive(node1);
        var result1 = _sut.HasCycleFastSlowPointers(node1);

        // Assert
        Assert.False(result0);
        Assert.False(result1);
    }
}