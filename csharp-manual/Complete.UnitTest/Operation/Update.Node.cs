namespace Complete.UnitTest.Operations;

public partial class Update{
    public class Node { 

        private LinkedNodeList<int>? sut;

        [Fact]
        public void UT001_Empty() {

            // Arrange
            sut = new();

            // Act
            sut.Update(100, 200);

            // Assert
            Assert.False(sut.HasPeek());
            Assert.False(sut.HasTail());

        }

        [Fact]
        public void UT002_Single() {

            // Arrange
            sut = new();

            // Act
            sut.AddFirst(100);
            sut.Update(100, 200);

            // Assert 
            Assert.True(sut.HasPeek());
            Assert.True(sut.HasTail());

        }

    }
}