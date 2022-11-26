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

        [Fact]
        public void UT003_Empty() {

            // Act
            _sut = new();

            // Assert 
            Assert.True(_sut.IsEmpty());

        }

        [Fact]
        public void UT003_NotEmpty(){

            // Arrange
            _sut = new();
            var temp0 = new Node<string>("AnyData0");
            var temp1 = new Node<string>("AnyData1");

            // Act
            temp0.Next = temp1;
            _sut.Next = temp0;

            // Assert 
            Assert.False(_sut.IsEmpty());

        }

    }
}