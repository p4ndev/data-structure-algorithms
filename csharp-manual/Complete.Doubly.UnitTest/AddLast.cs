namespace Complete.Doubly.UnitTest.Insert;

public class AddLast{

    private int _begin, _end;
    private LinkedNodeList? _sut;

    [Fact]
    public void UT001_Empty(){

        // Arrange
        _sut = new();
        _begin = _end = 0;

        // Act
        _begin = _sut.Count;
        _sut.AddLast(10);
        _end = _sut.Count;

        // Assert
        Assert.Equal(0, _begin);
        Assert.Equal(1, _end);

    }

    [Fact]
    public void UT002_Multiple(){

        // Arrange
        _sut = new();
        _begin = _end = 0;

        // Act
        _begin = _sut.Count;
        _sut.AddLast(10);
        _sut.AddLast(20);
        _sut.AddLast(30);
        _end = _sut.Count;

        // Assert
        Assert.Equal(0, _begin);
        Assert.Equal(3, _end);

    }

    [Fact]
    public void UT003_Data(){

        // Arrange
        int idx = 0;
        _sut = new();
        var arr = new[] { 30, 20, 10 };

        // Act
        _sut.AddLast(arr[idx + 2]); // 10
        _sut.AddLast(arr[idx + 1]); // 20
        _sut.AddLast(arr[idx]);     // 30

        // Assert
        foreach (var node in _sut.MovePrevious()){
            Assert.Equal(arr[idx], node.Data);
            idx++;
        }

    }

}