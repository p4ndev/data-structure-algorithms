namespace Complete.UnitTest.Operations;

public partial class Remove{
    public class Node{

        private LinkedNodeList<int>? sut;

        [Fact]
        public void UT001_RemoveFirst_Empty() {

            // Arrange
            sut = new();

            // Act
            sut.RemoveFirst();

            // Assert
            Assert.False(sut.HasPeek());
            Assert.False(sut.HasTail());

        }

        [Fact]
        public void UT002_RemoveLast_Empty() {

            // Arrange
            sut = new();

            // Act
            sut.AddFirst(100);
            sut.RemoveLast();

            // Assert
            Assert.False(sut.HasPeek());
            Assert.False(sut.HasTail());

        }

        [Fact]
        public void UT003_RemoveFirst_Singular() {

            // Arrange
            sut = new();

            // Act
            sut.AddFirst(100);
            sut.RemoveFirst();

            // Assert 
            Assert.False(sut.HasPeek());
            Assert.False(sut.HasTail());

        }

        [Fact]
        public void UT004_RemoveLast_Singular() {

            // Arrange
            sut = new();

            // Act
            sut.RemoveLast();

            // Assert
            Assert.False(sut.HasPeek());
            Assert.False(sut.HasTail());

        }

    }
}