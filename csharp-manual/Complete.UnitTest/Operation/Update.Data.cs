namespace Complete.UnitTest.Operations;

public partial class Update{
    public class Data { 

        private LinkedNodeList<int>? sut;

        public Data() {
            sut = new();
            sut.AddFirst(10);
            sut.AddLast(20);
            sut.AddLast(30);
            sut.AddLast(40);
            sut.AddLast(50);
        }

        [Fact]
        public void UT001_Head() {

            // Arrange
            sut!.Update(10, 15);

            // Act
            var first = sut!.First();

            // Assert
            Assert.NotNull(first);
            Assert.Equal(15, first!.Data);

        }

        [Fact]
        public void UT002_Tail() {

            // Arrange
            sut!.Update(50, 55);

            // Act
            var last = sut!.Last();

            // Assert
            Assert.NotNull(last);
            Assert.Equal(55, last!.Data);

        }

        [Fact]
        public void UT003_Middle(){

            // Arrange
            sut!.RemoveLast();
            sut!.RemoveLast();
            var last = sut!.Last();

            // Act
            sut!.Update(30, 35);

            // Assert
            Assert.NotNull(last);
            Assert.Equal(35, last!.Data);

        }

    }
}