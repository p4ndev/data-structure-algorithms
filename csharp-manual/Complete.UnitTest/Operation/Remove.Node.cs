namespace Complete.UnitTest.Operations;

public partial class Remove{
    public class Node{

        private LinkedNodeList<int>? _sut;

        [Fact]
        public void UT001_RemoveFirst_Empty() {

            // Arrange
            _sut = new();

            // Act
            _sut.RemoveFirst();

            // Assert
            Assert.False(_sut.HasPeek());
            Assert.False(_sut.HasTail());

        }

        [Fact]
        public void UT002_RemoveLast_Empty() {

            // Arrange
            _sut = new();

            // Act
            _sut.AddFirst(100);
            _sut.RemoveLast();

            // Assert
            Assert.False(_sut.HasPeek());
            Assert.False(_sut.HasTail());

        }

        [Fact]
        public void UT003_RemoveFirst_Singular() {

            // Arrange
            _sut = new();

            // Act
            _sut.AddFirst(100);
            _sut.RemoveFirst();

            // Assert 
            Assert.False(_sut.HasPeek());
            Assert.False(_sut.HasTail());

        }

        [Fact]
        public void UT004_RemoveLast_Singular() {

            // Arrange
            _sut = new();

            // Act
            _sut.RemoveLast();

            // Assert
            Assert.False(_sut.HasPeek());
            Assert.False(_sut.HasTail());

        }

    }
}