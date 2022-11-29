namespace Complete.UnitTest.Selects;

public class Both {

    private LinkedNodeList<int>? _sut;

    [Fact]
    public void UT001_Empty(){

        // Arrange
        _sut = new();
        
        // Act
        var three = _sut!.Find(3);

        // Assert 
        Assert.Null(three.Item);
        Assert.Equal(-1, three.Index);

    }

    [Fact]
    public void UT002_Single(){

        // Arrange
        _sut = new();

        // Act

        _sut.AddFirst(3);
        var three = _sut!.Find(3);

        // Assert 
        Assert.NotNull(three.Item);
        Assert.Equal(0, three.Index);

    }

    [Fact]
    public void UT003_Found_Fourty() {

        // Arrange
        _sut = new();
        _sut.AddFirst(10);
        _sut.AddLast(20);
        _sut.AddLast(30);
        _sut.AddLast(40);
        _sut.AddLast(50);

        // Act
        var fourty = _sut!.Find(40);

        // Assert 
        Assert.NotNull(fourty.Item);
        Assert.Equal(40, fourty.Item!.Data);
        Assert.Equal(3, fourty.Index);

    }

    [Fact]
    public void UT004_NotFound_Sixty() {

        // Arrange
        _sut = new();
        _sut.AddFirst(10);
        _sut.AddLast(20);
        _sut.AddLast(30);
        _sut.AddLast(40);
        _sut.AddLast(50);

        // Act
        var fourty = _sut!.Find(60);

        // Assert
        Assert.Null(fourty.Item);
        Assert.Equal(-1, fourty.Index);

    }

    [Fact]
    public void UT005_Found_Index() {

        // Arrange
        _sut = new();
        _sut.AddFirst(10);
        _sut.AddLast(20);
        _sut.AddLast(30);
        _sut.AddLast(40);
        _sut.AddLast(50);

        // Act
        var entry = _sut!.FindAt(2);

        // Assert
        Assert.NotNull(entry);
        Assert.Equal(30, entry!.Data);

    }

    [Fact]
    public void UT006_NotFound_Index() {

        // Arrange
        _sut = new();
        _sut.AddFirst(10);
        _sut.AddLast(20);
        _sut.AddLast(30);
        _sut.AddLast(40);
        _sut.AddLast(50);

        // Act
        var entry = _sut!.FindAt(30);

        // Assert
        Assert.Null(entry);

    }

}