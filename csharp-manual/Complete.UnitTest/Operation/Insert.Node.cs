namespace Complete.UnitTest.Operations;

public partial class Insert{
    public class Node {
    
        private LinkedNodeList<int>? _sut;

        [Fact]
        public void UT001_AddFirst_Empty() {

            // Arrange
            _sut = new();
            
            // Act
            _sut.AddFirst(10);

            // Assert
            Assert.True(_sut.HasPeek());
            Assert.True(_sut.HasTail());

        }

        [Fact]
        public void UT002_AddLast_Empty() {

            // Arrange
            _sut = new();

            // Act
            _sut.AddLast(10);

            // Assert
            Assert.True(_sut.HasPeek());
            Assert.True(_sut.HasTail());

        }

        [Fact]
        public void UT003_AddLast_Singular() {

            // Arrange
            _sut = new();
            
            // Act
            _sut.AddLast(10);
            _sut.AddLast(20);

            // Assert
            Assert.True(_sut.HasPeek());
            Assert.True(_sut.HasTail());

        }

        [Fact]
        public void UT004_AddFirst_Singular() {

            // Arrange
            _sut = new();

            // Act
            _sut.AddFirst(20);
            _sut.AddFirst(10);

            // Assert
            Assert.True(_sut.HasPeek());
            Assert.True(_sut.HasTail());

        }

        [Fact]
        public void UT005_Add_NonOrdered() {

            // Arrange
            _sut = new();

            // Act
            _sut.AddLast(20);
            _sut.AddLast(30);
            _sut.AddFirst(10);
            _sut.AddLast(40);
            _sut.AddLast(50);

            // Assert
            Assert.True(_sut.HasPeek());
            Assert.True(_sut.HasTail());

        }

    }
}