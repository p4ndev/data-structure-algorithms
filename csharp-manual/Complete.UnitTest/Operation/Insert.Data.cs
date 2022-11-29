namespace Complete.UnitTest.Operations;

public partial class Insert{
    public class Data {
    
        private LinkedNodeList<int>? _sut;

        [Fact]
        public void UT001_AddFirst_Empty(){

            // Arrange
            _sut = new();

            // Act
            _sut.AddFirst(10);

            // Assert
            var first = _sut.First();
            var last = _sut.Last();

            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

            Assert.NotNull(last);
            Assert.Equal(10, last!.Data);

        }

        [Fact]
        public void UT001_AddLast_Empty(){

            // Arrange
            _sut = new();

            // Act
            _sut.AddLast(10);

            // Assert
            var first = _sut.First();
            var last = _sut.Last();

            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

            Assert.NotNull(last);
            Assert.Equal(10, last!.Data);

        }

        [Fact]
        public void UT002_AddLastFirst_Singular(){

            // Arrange
            _sut = new();

            // Act
            _sut.AddLast(20);
            _sut.AddFirst(10);

            // Assert
            var first = _sut.First();
            var last = _sut.Last();

            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

            Assert.NotNull(last);
            Assert.Equal(20, last!.Data);

        }

        [Fact]
        public void UT003_AddFirstLast_Singular(){

            // Arrange
            _sut = new();

            // Act
            _sut.AddFirst(10);
            _sut.AddLast(20);

            // Assert
            var first = _sut.First();
            var last = _sut.Last();

            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

            Assert.NotNull(last);
            Assert.Equal(20, last!.Data);

        }

        [Fact]
        public void UT004_AddFirstLast_NonOrdered() {

            // Arrange
            _sut = new();

            // Act
            _sut.AddLast(20);
            _sut.AddLast(30);
            _sut.AddFirst(10);
            _sut.AddLast(40);
            _sut.AddLast(50);

            // Assert
            var first = _sut.First();
            var last = _sut.Last();

            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

            Assert.NotNull(last);
            Assert.Equal(50, last!.Data);

        }

        [Fact]
        public void UT005_AddAt_Beginning() {

            // Arrange
            _sut = new();
            _sut.AddLast(20);
            _sut.AddLast(30);

            // Act
            _sut.AddAt(10, 0);
            var first = _sut.First();

            // Assert
            Assert.NotNull(first);
            Assert.Equal(10, first!.Data);

        }

        [Fact]
        public void UT006_AddAt_End() {

            // Arrange
            _sut = new();
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(40);

            // Act
            _sut.AddAt(30, 2);
            var last = _sut.Last();

            // Assert 
            Assert.NotNull(last);
            Assert.Equal(40, last!.Data);

        }

        [Fact]
        public void UT006_AddAt_Middle() {

            // Arrange
            _sut = new();
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(40);
            _sut.AddLast(50);

            // Act
            _sut.AddAt(30, 2);
            var twenty = _sut.FindAt(1);
            var thirty = _sut.FindAt(2);
            var fourty = _sut.FindAt(3);

            // Assert
            Assert.NotNull(twenty);
            Assert.NotNull(thirty);
            Assert.NotNull(fourty);

            Assert.Equal(20, twenty!.Data);
            Assert.Equal(30, thirty!.Data);
            Assert.Equal(40, fourty!.Data);

        }

        [Fact]
        public void UT007_RemoveAt_FirstIndex() {
            
            // Arrange
            _sut = new();

            // Act
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(30);
            
            _sut.RemoveAt(0);
            var first = _sut.First();

            // Assert 
            Assert.NotNull(first);
            Assert.Equal(20, first!.Data);

        }

        [Fact]
        public void UT008_RemoveAt_LastIndex() {

            // Arrange
            _sut = new();

            // Act
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(30);

            _sut.RemoveAt(2);
            var last = _sut.Last();

            // Assert 
            Assert.NotNull(last);
            Assert.Equal(20, last!.Data);

        }

        [Fact]
        public void UT009_UpdateAt_FirstIndex_Head() {

            // Arrange
            _sut = new();
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(30);
            _sut.AddLast(40);

            // Act
            _sut.UpdateAt(15, 0);
            var first = _sut.First();

            // Assert 
            Assert.NotNull(first);
            Assert.Equal(15, first!.Data);

        }

        [Fact]
        public void UT010_UpdateAt_LastIndex_Tail() {

            // Arrange
            _sut = new();
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(30);
            _sut.AddLast(40);

            // Act
            _sut.UpdateAt(45, 3);
            var last = _sut.Last();

            // Assert 
            Assert.NotNull(last);
            Assert.Equal(45, last!.Data);

        }

    }
}