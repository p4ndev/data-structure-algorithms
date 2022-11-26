namespace Complete.UnitTest.Object.Singular;

public partial class Node{
    public class Next { 

        private Node<string>? _sut;

        [Fact]
        public void UT001_Null(){
            
            // Arrange
            _sut = new();

            // Assert
            Assert.False(_sut.HasNext());

        }

        [Fact]
        public void UT002_Comparison() {

            // Arrange
            _sut = new();
            
            // Act
            _sut.Next = new Node<string>("AnyData1");

            // Assert
            Assert.True(_sut.HasNext());
            Assert.False(_sut.Next.HasNext());

        }

    }
}