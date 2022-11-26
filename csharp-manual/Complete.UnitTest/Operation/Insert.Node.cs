namespace Complete.UnitTest.Operations;

public partial class Insert{
    public class Node {
    
        private LinkedNodeList<int>? sut;

        [Fact]
        public void UT001_AddFirst_Empty() {

            // Arrange
            sut = new();
            
            // Act
            sut.AddFirst(10);

            // Assert
            Assert.True(sut.HasPeek());
            Assert.True(sut.HasTail());

        }

        [Fact]
        public void UT002_AddLast_Empty() {

            // Arrange
            sut = new();

            // Act
            sut.AddLast(10);

            // Assert
            Assert.True(sut.HasPeek());
            Assert.True(sut.HasTail());

        }

        [Fact]
        public void UT003_AddLast_Singular() {

            // Arrange
            sut = new();
            
            // Act
            sut.AddLast(10);
            sut.AddLast(20);

            // Assert
            Assert.True(sut.HasPeek());
            Assert.True(sut.HasTail());

        }

        [Fact]
        public void UT004_AddFirst_Singular() {

            // Arrange
            sut = new();

            // Act
            sut.AddFirst(20);
            sut.AddFirst(10);

            // Assert
            Assert.True(sut.HasPeek());
            Assert.True(sut.HasTail());

        }

        [Fact]
        public void UT005_Add_NonOrdered() {

            // Arrange
            sut = new();

            // Act
            sut.AddLast(20);
            sut.AddLast(30);
            sut.AddFirst(10);
            sut.AddLast(40);
            sut.AddLast(50);

            // Assert
            Assert.True(sut.HasPeek());
            Assert.True(sut.HasTail());

        }
    
    }
}