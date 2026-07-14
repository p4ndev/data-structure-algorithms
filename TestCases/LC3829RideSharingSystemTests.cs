namespace LC3829;

public class RideSharingSystemTests
{
    private readonly Problems.LC3829 _sut;

    public RideSharingSystemTests()
        => _sut = new();

    [Fact]
    public void Should_Return_MinusOne_When_System_Is_Empty()
    {
        // Act
        var result = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { -1, -1 }, result);
    }

    [Fact]
    public void Should_Return_MinusOne_When_Only_Riders_Exist()
    {
        // Arrange
        _sut.AddRider(1);

        // Act
        var result = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { -1, -1 }, result);
    }

    [Fact]
    public void Should_Return_MinusOne_When_Only_Drivers_Exist()
    {
        // Arrange
        _sut.AddDriver(10);

        // Act
        var result = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { -1, -1 }, result);
    }

    [Fact]
    public void Should_Match_Single_Driver_And_Rider()
    {
        // Arrange
        _sut.AddRider(1);
        _sut.AddDriver(10);

        // Act
        var result = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { 10, 1 }, result);
    }

    [Fact]
    public void Should_Match_Riders_In_FIFO_Order()
    {
        // Arrange
        _sut.AddRider(1);
        _sut.AddRider(2);
        _sut.AddDriver(10);
        _sut.AddDriver(20);

        // Act
        var first = _sut.MatchDriverWithRider();
        var second = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { 10, 1 }, first);
        Assert.Equal(new[] { 20, 2 }, second);
    }

    [Fact]
    public void Should_Match_Drivers_In_FIFO_Order()
    {
        // Arrange
        _sut.AddDriver(10);
        _sut.AddDriver(20);
        _sut.AddRider(1);
        _sut.AddRider(2);

        // Act
        var first = _sut.MatchDriverWithRider();
        var second = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { 10, 1 }, first);
        Assert.Equal(new[] { 20, 2 }, second);
    }

    [Fact]
    public void Should_Skip_Cancelled_Rider()
    {
        // Arrange
        _sut.AddRider(1);
        _sut.AddRider(2);
        _sut.CancelRider(1);
        _sut.AddDriver(10);

        // Act
        var result = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { 10, 2 }, result);
    }

    [Fact]
    public void Should_Return_MinusOne_When_All_Riders_Are_Cancelled()
    {
        // Arrange
        _sut.AddRider(1);
        _sut.AddRider(2);
        _sut.CancelRider(1);
        _sut.CancelRider(2);
        _sut.AddDriver(10);

        // Act
        var result = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { -1, -1 }, result);
    }

    [Fact]
    public void Should_Ignore_Cancel_Of_Already_Matched_Rider()
    {
        // Arrange
        _sut.AddRider(1);
        _sut.AddDriver(10);
        _sut.MatchDriverWithRider();
        _sut.CancelRider(1);

        // Act
        var result = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { -1, -1 }, result);
    }

    [Fact]
    public void Should_Ignore_Cancel_Of_Nonexistent_Rider()
    {
        // Arrange
        _sut.CancelRider(999);
        _sut.AddRider(1);
        _sut.AddDriver(10);

        // Act
        var result = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { 10, 1 }, result);
    }

    [Fact]
    public void Should_Follow_LeetCode_Example_One()
    {
        // Arrange
        _sut.AddRider(3);
        _sut.AddDriver(2);
        _sut.AddRider(1);

        // Act
        var firstMatch = _sut.MatchDriverWithRider();

        _sut.AddDriver(5);
        _sut.CancelRider(3);

        var secondMatch = _sut.MatchDriverWithRider();
        var thirdMatch = _sut.MatchDriverWithRider();

        // Assert
        Assert.Equal(new[] { 2, 3 }, firstMatch);
        Assert.Equal(new[] { 5, 1 }, secondMatch);
        Assert.Equal(new[] { -1, -1 }, thirdMatch);
    }

    [Fact]
    public void Should_Follow_LeetCode_Example_Two()
    {
        // Arrange
        _sut.AddRider(8);
        _sut.AddDriver(8);
        _sut.AddDriver(6);

        // Act
        var firstMatch = _sut.MatchDriverWithRider();

        _sut.AddRider(2);
        _sut.CancelRider(2);

        var secondMatch = _sut.MatchDriverWithRider();

        //Assert
        Assert.Equal(new[] { 8, 8 }, firstMatch);
        Assert.Equal(new[] { -1, -1 }, secondMatch);
    }
}