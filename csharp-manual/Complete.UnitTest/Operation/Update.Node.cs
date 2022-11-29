namespace Complete.UnitTest.Operations;

public partial class Update{
    public class Node { 

        private LinkedNodeList<int>? _sut;

        [Fact]
        public void UT001_Empty() {

            // Arrange
            _sut = new();

            // Act
            _sut.Update(100, 200);

            // Assert
            Assert.False(_sut.HasPeek());
            Assert.False(_sut.HasTail());

        }

        [Fact]
        public void UT002_Single() {

            // Arrange
            _sut = new();

            // Act
            _sut.AddFirst(100);
            _sut.Update(100, 200);

            // Assert 
            Assert.True(_sut.HasPeek());
            Assert.True(_sut.HasTail());

        }

    }
}