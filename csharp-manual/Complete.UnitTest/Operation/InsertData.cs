namespace Complete.UnitTest.Operations;

public partial class Insert{
    public class Data {
    
        private LinkedNodeList<int>? sut;

        [Fact]
        public void UT001_AddFirst_Empty(){

            // Arrange
            sut = new();

            // Act
            sut.AddFirst(10);

            // Assert
            var first = sut.First();
            var last = sut.Last();

            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

            Assert.NotNull(last);
            Assert.Equal(10, last!.Data);

        }

        [Fact]
        public void UT001_AddLast_Empty(){

            // Arrange
            sut = new();

            // Act
            sut.AddLast(10);

            // Assert
            var first = sut.First();
            var last = sut.Last();

            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

            Assert.NotNull(last);
            Assert.Equal(10, last!.Data);

        }

        [Fact]
        public void UT002_AddLastFirst_Singular(){

            // Arrange
            sut = new();

            // Act
            sut.AddLast(20);
            sut.AddFirst(10);

            // Assert
            var first = sut.First();
            var last = sut.Last();

            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

            Assert.NotNull(last);
            Assert.Equal(20, last!.Data);

        }

        [Fact]
        public void UT003_AddFirstLast_Singular(){

            // Arrange
            sut = new();

            // Act
            sut.AddFirst(10);
            sut.AddLast(20);

            // Assert
            var first = sut.First();
            var last = sut.Last();

            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

            Assert.NotNull(last);
            Assert.Equal(20, last!.Data);

        }

        [Fact]
        public void UT004_AddFirstLast_NonOrdered() {

            // Arrange
            sut = new();

            // Act
            sut.AddLast(20);
            sut.AddLast(30);
            sut.AddFirst(10);
            sut.AddLast(40);
            sut.AddLast(50);

            // Assert
            var first = sut.First();
            var last = sut.Last();

            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

            Assert.NotNull(last);
            Assert.Equal(50, last!.Data);

        }

    }
}