namespace Complete.UnitTest.Object.Multiple;

public partial class LinkedNodeList{
    public class Data { 

        private LinkedNodeList<string> _sut = new();

        [Fact]
        public void UT001_ZeroCounter() => Assert.Equal(0, _sut.Count);

        [Fact]
        public void UT002_PeekAndTail(){
            
            // Act
            _sut.AddFirst("AnyData");

            // Assert
            Assert.True(_sut.HasPeek());
            Assert.True(_sut.HasTail());

        }

    }
}