namespace Complete.UnitTest.Object.Singular;

public partial class Node{
    public class Data{

        private Node<string>? _sut;

        [Fact]
        public void UT001_Empty() {

            // Arrange
            _sut = new();

            // Assert
            Assert.False(_sut.HasData());

        }

        [Fact]
        public void UT002_BruteForce_Comparison() {
            
            // Arrange
            _sut = new Node<string>("AnyData");

            // Assert 
            Assert.True(_sut.HasData());
            Assert.Equal("AnyData", _sut.Data);

        }

        [Fact]
        public void UT003_Functional_Comparison() {
            
            // Arrange
            _sut = new Node<string>("AnyData");

            // Assert 
            Assert.True(_sut.HasData());
            Assert.True(_sut.IsEqual("AnyData"));

        }

    }
}