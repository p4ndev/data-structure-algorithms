namespace Complete.UnitTest.Operations;

public partial class Remove{
    public class Data{

        private LinkedNodeList<int>? _sut;

        [Fact]
        public void UT001_RemoveFirst_Multiple() {

            // Arrange
            _sut = new();
            _sut.AddLast(20);
            _sut.AddFirst(10);
            _sut.AddLast(30);

            // Act
            _sut.RemoveFirst();

            // Assert 
            var first = _sut.First();
            var last = _sut.Last();

            Assert.NotNull(first);
            Assert.NotNull(last);

            Assert.Equal(20, first!.Data);
            Assert.Equal(30, last!.Data);

        }

        [Fact]
        public void UT002_RemoveLast_Multiple() {

            // Arrange
            _sut = new();
            _sut.AddLast(20);
            _sut.AddLast(30);
            _sut.AddFirst(10);

            // Act
            _sut.RemoveLast();

            // Assert
            var first = _sut.First();
            var last = _sut.Last();

            Assert.NotNull(first);
            Assert.NotNull(last);

            Assert.Equal(10, first!.Data);
            Assert.Equal(20, last!.Data);

        }

        [Fact]
        public void UT003_RemoveFirst_Single() {

            // Arrange
            _sut = new();
            _sut.AddFirst(100);

            // Act
            _sut.RemoveFirst();

            // Assert
            var first = _sut.First();
            var last = _sut.Last();

            Assert.Null(first);
            Assert.Null(last);

        }

        [Fact]
        public void UT004_RemoveLast_Single() {

            // Arrange
            _sut = new();
            _sut.AddLast(100);
            
            // Act
            _sut.RemoveLast();

            // Assert
            var first = _sut.First();
            var last = _sut.Last();

            Assert.Null(first);
            Assert.Null(last);

        }

        [Fact]
        public void UT005_RemoveAt_Found() {

            // Arrange
            _sut = new();
            _sut.AddFirst(200);
            _sut.AddFirst(100);
            _sut.AddLast(300);
            _sut.AddLast(400);
            _sut.AddLast(500);

            // Act
            _sut.RemoveAt(2);
            var fourHundred = _sut.FindAt(2);

            // Assert
            Assert.NotNull(fourHundred);
            Assert.Equal(400, fourHundred!.Data);

        }

        [Fact]
        public void UT005_RemoveAt_NotFound(){

            // Arrange
            _sut = new();
            _sut.AddFirst(200);
            _sut.AddFirst(100);
            _sut.AddLast(300);
            _sut.AddLast(400);
            _sut.AddLast(500);

            // Act
            _sut.RemoveAt(30);
            var fourHundred = _sut.FindAt(30);

            // Assert
            Assert.Null(fourHundred);

        }

        [Fact]
        public void UT006_RemoveAt_Beginning(){

            // Arrange
            _sut = new();
            _sut.AddFirst(200);
            _sut.AddFirst(100);
            _sut.AddLast(300);
            _sut.AddLast(400);
            _sut.AddLast(500);

            // Act
            _sut.RemoveAt(0);
            var twoHundred = _sut.FindAt(0);

            // Assert
            Assert.NotNull(twoHundred);
            Assert.Equal(200, twoHundred!.Data);

        }

        [Fact]
        public void UT007_RemoveAt_End(){

            // Arrange
            _sut = new();
            _sut.AddFirst(200);
            _sut.AddFirst(100);
            _sut.AddLast(300);
            _sut.AddLast(400);
            _sut.AddLast(500);

            // Act
            _sut.RemoveAt(4);
            var fourHundred = _sut.FindAt(3);

            // Assert
            Assert.NotNull(fourHundred);
            Assert.Equal(400, fourHundred!.Data);

        }

        [Fact]
        public void UT008_RemoveAt_WrongIndexes(){

            // Arrange
            _sut = new();
            _sut.AddFirst(200);
            _sut.AddFirst(100);
            _sut.AddLast(300);
            _sut.AddLast(400);
            _sut.AddLast(500);

            // Act
            _sut.RemoveAt(-54);
            _sut.RemoveAt(54);
            
            var first = _sut.FindAt(0);
            var last = _sut.FindAt(4);

            // Assert
            Assert.NotNull(first);
            Assert.NotNull(last);

            Assert.Equal(100, first!.Data);
            Assert.Equal(500, last!.Data);

        }

    }
}