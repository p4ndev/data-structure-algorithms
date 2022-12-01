namespace Complete.Doubly.UnitTest.Select;

public  class Select{

    private int _idx;
    private LinkedNodeList _sut;

    public Select(){
        
        _sut = new();
        _idx = 0;

        _sut.AddFirst(2);
        _sut.AddFirst(1);

        _sut.AddLast(3);
        _sut.AddLast(4);
        _sut.AddLast(5);

    }

    [Fact]
    public void UT001_MoveNext() {

        // Arrange
        int[] arr = { 1, 2, 3, 4, 5 };
        bool foundDifference = false;
        string msg = string.Empty;

        // Act
        foreach (Node item in _sut.MoveNext()){
            if (!arr[_idx].Equals(item.Data)) {
                foundDifference = true;
                msg = "Found @ index " + _idx;
                break;
            }
            _idx++;
        }

        // Assert 
        Assert.False(foundDifference, msg);

    }

    [Fact]
    public void UT002_MovePrevious() {
    
        // Arrange
        int[] arr = { 5, 4, 3, 2, 1 };
        bool foundDifference = false;
        string msg = string.Empty;

        // Act
        foreach (Node item in _sut.MovePrevious()){
            if (!arr[_idx].Equals(item.Data)) {
                foundDifference = true;
                msg = "Found @ index " + _idx;
                break;
            }
            _idx++;
        }

        // Assert 
        Assert.False(foundDifference, msg);
    
    }

    [Fact]
    public void UT003_Head() {
        
        // Act
        var top = _sut.FirstOrDefault();

        // Assert 
        Assert.NotNull(top);
        Assert.Equal(1, top!.Data);

    }

    [Fact]
    public void UT004_Tail() {

        // Act
        var bottom = _sut.LastOrDefault();

        // Assert 
        Assert.NotNull(bottom);
        Assert.Equal(5, bottom!.Data);

    }

    [Fact]
    public void UT005_FindBy_Index() {

        // Act
        var three = _sut.ElementAt(2);

        // Assert 
        Assert.NotNull(three);
        Assert.Equal(3, three!.Data);

    }

    [Fact]
    public void UT006_FindBy_Data() {

        // Act
        var four = _sut.SingleOrDefault(4);

        // Assert 
        Assert.NotNull(four);
        Assert.Equal(4, four!.Data);

    }

    [Fact]
    public void UT007_Empty_Scenarios() {

        // Arrange
        _sut = new();

        // Act
        var four    = _sut.SingleOrDefault(4);
        var top     = _sut.FirstOrDefault();
        var bottom  = _sut.FirstOrDefault();
        var three   = _sut.ElementAt(2);

        // Assert 
        Assert.Null(top);
        Assert.Null(bottom);
        Assert.Null(three);
        Assert.Null(four);

    }

}
