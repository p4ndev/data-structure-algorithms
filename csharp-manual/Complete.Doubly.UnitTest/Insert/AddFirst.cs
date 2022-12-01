namespace Complete.Doubly.UnitTest.Insert;

public class AddFirst{

    private int _begin, _end;
    private LinkedNodeList? _sut;

    [Fact]
    public void UT001_Empty(){

        // Arrange
        _sut = new();
        _begin = _end = 0;

        // Act
        _begin = _sut.Count;
        _sut.AddFirst(10);
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
        _sut.AddFirst(30);
        _sut.AddFirst(20);
        _sut.AddFirst(10);
        _end = _sut.Count;

        // Assert
        Assert.Equal(0, _begin);
        Assert.Equal(3, _end);

    }

    [Fact]
    public void UT003_Data() {

        // Arrange
        int idx = 0;
        _sut = new();
        var arr = new[] { 10, 20, 30 };

        // Act
        _sut.AddFirst(arr[idx + 2]);
        _sut.AddFirst(arr[idx + 1]);
        _sut.AddFirst(arr[idx]);

        // Assert
        foreach (var node in _sut.MoveNext()) {
            Assert.Equal(arr[idx], node.Data);
            idx++;
        }

    }

}