namespace Complete.UnitTest.Selects;

public class Both {

    private LinkedNodeList<int>? sut;

    [Fact]
    public void UT001_Empty(){

        // Arrange
        sut = new();
        
        // Act
        var three = sut!.Find(3);

        // Assert 
        Assert.Null(three.Item);
        Assert.Equal(-1, three.Index);

    }

    [Fact]
    public void UT002_Single(){

        // Arrange
        sut = new();

        // Act

        sut.AddFirst(3);
        var three = sut!.Find(3);

        // Assert 
        Assert.NotNull(three.Item);
        Assert.Equal(0, three.Index);

    }

    [Fact]
    public void UT003_Found_Fourty() {

        // Arrange
        sut = new();
        sut.AddFirst(10);
        sut.AddLast(20);
        sut.AddLast(30);
        sut.AddLast(40);
        sut.AddLast(50);

        // Act
        var fourty = sut!.Find(40);

        // Assert 
        Assert.NotNull(fourty.Item);
        Assert.Equal(40, fourty.Item!.Data);
        Assert.Equal(3, fourty.Index);

    }

    [Fact]
    public void UT004_NotFound_Sixty() {

        // Arrange
        sut = new();
        sut.AddFirst(10);
        sut.AddLast(20);
        sut.AddLast(30);
        sut.AddLast(40);
        sut.AddLast(50);

        // Act
        var fourty = sut!.Find(60);

        // Assert
        Assert.Null(fourty.Item);
        Assert.Equal(-1, fourty.Index);

    }

    [Fact]
    public void UT005_Found_Index() {

        // Arrange
        sut = new();
        sut.AddFirst(10);
        sut.AddLast(20);
        sut.AddLast(30);
        sut.AddLast(40);
        sut.AddLast(50);

        // Act
        var entry = sut!.FindAt(2);

        // Assert
        Assert.NotNull(entry);
        Assert.Equal(30, entry!.Data);

    }

    [Fact]
    public void UT006_NotFound_Index() {

        // Arrange
        sut = new();
        sut.AddFirst(10);
        sut.AddLast(20);
        sut.AddLast(30);
        sut.AddLast(40);
        sut.AddLast(50);

        // Act
        var entry = sut!.FindAt(30);

        // Assert
        Assert.Null(entry);

    }

}