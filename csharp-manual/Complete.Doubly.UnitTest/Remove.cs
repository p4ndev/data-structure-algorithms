namespace Complete.Doubly.UnitTest.Remove;

public class Remove {

    private LinkedNodeList _sut;
    private int _idx;

    public Remove(){

        _sut = new();
        _idx = 0;

        _sut.AddFirst(2);
        _sut.AddFirst(1);

        _sut.AddLast(3);
        _sut.AddLast(4);
        _sut.AddLast(5);

    }

    [Fact]
    public void UT001_RemoveAll() {

        // Act
        _sut.RemoveAll();

        // Assert
        Assert.Equal(0, _sut.Count);

    }

    [Fact]
    public void UT002_RemoveFirst() {

        // Act
        _sut.RemoveFirst();

        // Assert
        Assert.Equal(4, _sut.Count);

    }

    [Fact]
    public void UT003_RemoveLast() {
        
        // Act
        _sut.RemoveLast();

        // Assert
        Assert.Equal(4, _sut.Count);

    }

    [Fact]
    public void UT004_Data() {

        // Arrange
        int[] _data = { 2, 3, 4 };

        // Act
        _sut.RemoveFirst();
        _sut.RemoveLast();

        // Assert 
        Assert.Equal(3, _sut.Count);
        foreach (Node item in _sut.MoveNext()) {
            Assert.Equal(_data[_idx], item.Data);
            _idx++;
        }

    }

    [Fact]
    public void UT005_RemoveAt() {

        // Arrange
        int[] _data = { 1, 2, 3, 5 };

        // Act
        _sut.RemoveAt(3);

        // Assert 
        Assert.Equal(4, _sut.Count);
        foreach (Node item in _sut.MoveNext()) {
            Assert.Equal(_data[_idx], item.Data);
            _idx++;
        }

    }

    [Fact]
    public void UT006_Remove() {

        // Arrange
        bool foundThree = false;

        // Act
        foreach (Node item in _sut.MoveNext())
            if (item.Data.Equals(3))
                _sut.Remove(item);

        foreach(Node item in _sut.MoveNext())
            if (item.Data.Equals(3)){
                foundThree = true;
                break;
            }


        // Assert 
        Assert.Equal(4, _sut.Count);
        Assert.False(foundThree);

    }

}