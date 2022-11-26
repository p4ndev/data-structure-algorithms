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

    }
}