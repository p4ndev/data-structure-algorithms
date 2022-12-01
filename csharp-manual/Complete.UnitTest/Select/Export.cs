namespace Complete.UnitTest.Selects;

public class Export {

    private LinkedNodeList<int>? _sut;

    [Fact]
    private void UT001_Array() {

        // Arrange
        _sut = new();
        _sut.AddFirst(10);
        _sut.AddLast(20);
        _sut.AddLast(30);
        _sut.AddLast(40);
        _sut.AddLast(50);

        // Act
        var arr = _sut.ToArray();
        var exp = new int[] { 10, 20, 30, 40, 50 };

        // Assert 
        Assert.Equal(exp, arr);

    }

    [Fact]
    private void UT002_Stream() {

        // Arrange
        _sut = new();
        _sut.AddFirst(10);
        _sut.AddLast(20);
        _sut.AddLast(30);
        _sut.AddLast(40);
        _sut.AddLast(50);

        // Act
        var idx = 0;
        var str = _sut.ToStream();
        var exp = new int[] { 10, 20, 30, 40, 50 };

        // Assert 
        foreach (var num in str) {
            Assert.Equal(exp[idx], num);
            idx++;
        }

    }

}