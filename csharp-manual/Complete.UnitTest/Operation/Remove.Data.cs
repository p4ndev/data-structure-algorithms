namespace Complete.UnitTest.Operations;

public partial class Remove{
    public class Data{

        private LinkedNodeList<int>? sut;

        [Fact]
        public void UT001_RemoveFirst_Multiple() {

            // Arrange
            sut = new();
            sut.AddLast(20);
            sut.AddFirst(10);
            sut.AddLast(30);

            // Act
            sut.RemoveFirst();

            // Assert 
            var first = sut.First();
            var last = sut.Last();

            Assert.NotNull(first);
            Assert.NotNull(last);

            Assert.Equal(20, first!.Data);
            Assert.Equal(30, last!.Data);

        }

        [Fact]
        public void UT002_RemoveLast_Multiple() {

            // Arrange
            sut = new();
            sut.AddLast(20);
            sut.AddLast(30);
            sut.AddFirst(10);

            // Act
            sut.RemoveLast();

            // Assert
            var first = sut.First();
            var last = sut.Last();

            Assert.NotNull(first);
            Assert.NotNull(last);

            Assert.Equal(10, first!.Data);
            Assert.Equal(20, last!.Data);

        }

        [Fact]
        public void UT003_RemoveFirst_Single() {

            // Arrange
            sut = new();
            sut.AddFirst(100);

            // Act
            sut.RemoveFirst();

            // Assert
            var first = sut.First();
            var last = sut.Last();

            Assert.Null(first);
            Assert.Null(last);

        }

        [Fact]
        public void UT004_RemoveLast_Single() {

            // Arrange
            sut = new();
            sut.AddLast(100);
            
            // Act
            sut.RemoveLast();

            // Assert
            var first = sut.First();
            var last = sut.Last();

            Assert.Null(first);
            Assert.Null(last);

        }

        [Fact]
        public void UT005_RemoveAt_Found() {

            // Arrange
            sut = new();
            sut.AddFirst(200);
            sut.AddFirst(100);
            sut.AddLast(300);
            sut.AddLast(400);
            sut.AddLast(500);

            // Act
            sut.RemoveAt(2);
            var fourHundred = sut.FindAt(2);

            // Assert
            Assert.NotNull(fourHundred);
            Assert.Equal(400, fourHundred!.Data);

        }

        [Fact]
        public void UT005_RemoveAt_NotFound(){

            // Arrange
            sut = new();
            sut.AddFirst(200);
            sut.AddFirst(100);
            sut.AddLast(300);
            sut.AddLast(400);
            sut.AddLast(500);

            // Act
            sut.RemoveAt(30);
            var fourHundred = sut.FindAt(30);

            // Assert
            Assert.Null(fourHundred);

        }

        [Fact]
        public void UT006_RemoveAt_Beginning(){

            // Arrange
            sut = new();
            sut.AddFirst(200);
            sut.AddFirst(100);
            sut.AddLast(300);
            sut.AddLast(400);
            sut.AddLast(500);

            // Act
            sut.RemoveAt(0);
            var twoHundred = sut.FindAt(0);

            // Assert
            Assert.NotNull(twoHundred);
            Assert.Equal(200, twoHundred!.Data);

        }

        [Fact]
        public void UT007_RemoveAt_End(){

            // Arrange
            sut = new();
            sut.AddFirst(200);
            sut.AddFirst(100);
            sut.AddLast(300);
            sut.AddLast(400);
            sut.AddLast(500);

            // Act
            sut.RemoveAt(4);
            var fourHundred = sut.FindAt(3);

            // Assert
            Assert.NotNull(fourHundred);
            Assert.Equal(400, fourHundred!.Data);

        }

        [Fact]
        public void UT008_RemoveAt_WrongIndexes(){

            // Arrange
            sut = new();
            sut.AddFirst(200);
            sut.AddFirst(100);
            sut.AddLast(300);
            sut.AddLast(400);
            sut.AddLast(500);

            // Act
            sut.RemoveAt(-54);
            sut.RemoveAt(54);
            
            var first = sut.FindAt(0);
            var last = sut.FindAt(4);

            // Assert
            Assert.NotNull(first);
            Assert.NotNull(last);

            Assert.Equal(100, first!.Data);
            Assert.Equal(500, last!.Data);

        }

    }
}