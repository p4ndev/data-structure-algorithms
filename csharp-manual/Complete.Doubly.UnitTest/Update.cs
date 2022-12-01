namespace Complete.Doubly.UnitTest.Update;

public class Update{

    private LinkedNodeList _sut;

    public Update(){

        _sut = new();

        _sut.AddFirst(2);
        _sut.AddFirst(1);

        _sut.AddLast(3);
        _sut.AddLast(4);
        _sut.AddLast(5);

    }

    [Fact]
    public void UT001_Update_First(){

        // Act
        var result = _sut.Update(1, 10);

        // Assert        
        Assert.True(result);

    }

    [Fact]
    public void UT002_Update_Last(){

        // Act
        var result = _sut.Update(5, 50);

        // Assert
        Assert.True(result);

    }

    [Fact]
    public void UT003_Update_Middle(){

        // Act
        var result = _sut.Update(3, 30);

        // Assert
        Assert.True(result);

    }

    [Fact]
    public void UT004_Update_NotFound(){

        // Act
        var result = _sut.Update(100, 1);

        // Assert
        Assert.False(result);

    }

    [Fact]
    public void UT005_Data(){

        // Arrange
        var _action = new bool[3];
        var _data = new[] { 10, 2, 30, 4, 50 };

        // Act
        _action[0] = _sut.Update(1, 10);
        _action[1] = _sut.Update(3, 30);
        _action[2] = _sut.Update(5, 50);

        // Assert 
        int idx = 0;
        foreach (Node node in _sut.MoveNext()) {

            Assert.Equal(_data[idx], node.Data);

            switch (idx) {

                case 0:
                    Assert.True(_action[0]);
                    break;

                case 2:
                    Assert.True(_action[1]);
                    break;

                case 4:
                    Assert.True(_action[2]);
                    break;

            }

            idx++;
        }

    }

}