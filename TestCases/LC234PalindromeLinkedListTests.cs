namespace LC234;

public class LC234PalindromeLinkedListTests
{
    private readonly Problems.LC234 _sut;

    public LC234PalindromeLinkedListTests()
        => _sut = new();

    [Fact]
    public void Should_Return_True_When_List_Is_Empty()
    {
        // Act
        var result0 = _sut.IsPalindromeExtraSpace(null);
        var result1 = _sut.IsPalindrome(null);

        // Assert
        Assert.True(result0);
        Assert.True(result1);
    }

    [Fact]
    public void Should_Return_True_When_List_Has_One_Node()
    {
        // Arrange
        var head = new ListNode(1);

        // Act
        var result0 = _sut.IsPalindromeExtraSpace(head);
        var result1 = _sut.IsPalindrome(head);

        // Assert
        Assert.True(result0);
        Assert.True(result1);
    }

    [Fact]
    public void Should_Return_True_When_List_Is_Even_Palindrome()
    {
        // Arrange
        var head = Problems.Shared.Utils.CreateList(1, 2, 2, 1);

        // Act
        var result0 = _sut.IsPalindromeExtraSpace(head);
        var result1 = _sut.IsPalindrome(head);

        // Assert
        Assert.True(result0);
        Assert.True(result1);
    }

    [Fact]
    public void Should_Return_True_When_List_Is_Odd_Palindrome()
    {
        // Arrange
        var head = Problems.Shared.Utils.CreateList(1, 2, 3, 2, 1);

        // Act
        var result0 = _sut.IsPalindromeExtraSpace(head);
        var result1 = _sut.IsPalindrome(head);

        // Assert
        Assert.True(result0);
        Assert.True(result1);
    }

    [Fact]
    public void Should_Return_True_When_List_Is_Odd_Palindrome_Simple()
    {
        // Arrange
        var head = Problems.Shared.Utils.CreateList(1,0,1);

        // Act
        var result0 = _sut.IsPalindromeExtraSpace(head);
        var result1 = _sut.IsPalindrome(head);

        // Assert
        Assert.True(result0);
        Assert.True(result1);
    }

    [Fact]
    public void Should_Return_False_When_List_Is_Not_Palindrome()
    {
        // Arrange
        var head = Problems.Shared.Utils.CreateList(1, 2, 3);

        // Act
        var result0 = _sut.IsPalindromeExtraSpace(head);
        var result1 = _sut.IsPalindrome(head);

        // Assert
        Assert.False(result0);
        Assert.False(result1);
    }

    [Fact]
    public void Should_Return_False_When_Only_Last_Value_Differs()
    {
        // Arrange
        var head = Problems.Shared.Utils.CreateList(1, 2, 2, 3);

        // Act
        var result0 = _sut.IsPalindromeExtraSpace(head);
        var result1 = _sut.IsPalindrome(head);

        // Assert
        Assert.False(result0);
        Assert.False(result1);
    }
}