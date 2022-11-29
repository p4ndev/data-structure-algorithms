namespace Complete.UnitTest.Object.Multiple;

public partial class LinkedNodeList{
    public class Node { 

        private LinkedNodeList<string> _sut = new();

        [Fact]
        public void UT001_NoPeek() => Assert.False(_sut.HasPeek());

        [Fact]
        public void UT002_NoTail() => Assert.False(_sut.HasTail());

        [Fact]
        public void UT003_Empty() => Assert.True(_sut.IsEmpty());

        [Fact]
        public void UT004_NotEmpty() {

            // Arrange
            _sut.AddFirst("Gustavo");
            _sut.AddLast("Henrique");

            // Assert
            Assert.False(_sut.IsEmpty());

        }

        [Fact]
        public void UT005_Index_Inside() {

            // Arrange
            _sut.AddLast("Marcos");
            _sut.AddLast("Santos");
            _sut.AddLast("Gustavo");
            _sut.AddLast("Henrique");

            // Act
            var entry = _sut.IsOutside(2);

            // Assert
            Assert.False(entry);

        }

        [Fact]
        public void UT006_Index_Outside() {

            // Act
            var entry0 = _sut.IsOutside(200);
            var entry1 = _sut.IsOutside(-200);

            // Assert
            Assert.True(entry0);
            Assert.True(entry1);

        }

    }
}