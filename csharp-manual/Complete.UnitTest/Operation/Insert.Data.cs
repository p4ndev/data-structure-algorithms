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

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void UT011_AddBefore(bool isFirstOperation) {

            // Arrange
            _sut = new();
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(30);

            // Act
            if (isFirstOperation)
                _sut.AddBefore(5, 10);
            else
                _sut.AddBefore(25, 30);

            // Assert 
            if (isFirstOperation) {
                var first = _sut.First();
                Assert.NotNull(first);
                Assert.Equal(5, first!.Data);
            } else {
                var last = _sut.Last();
                Assert.NotNull(last);
                Assert.Equal(30, last!.Data);
            }

        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void UT012_AddAfter(bool isFirstOperation) {

            // Arrange
            _sut = new();
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(30);

            // Act
            if (isFirstOperation)
                _sut.AddAfter(15, 10);
            else
                _sut.AddAfter(35, 30);

            // Assert 
            if (isFirstOperation) {
                var first = _sut.First();
                Assert.NotNull(first);
                Assert.Equal(10, first!.Data);
            } else {
                var last = _sut.Last();
                Assert.NotNull(last);
                Assert.Equal(35, last!.Data);
            }

        }

        [Fact]
        public void UT013_AddBefore_Middle() {

            // Arrange
            _sut = new();
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(30);

            // Act
            _sut.AddBefore(15, 20);
            var fifteen = _sut.FindAt(1);

            // Assert 
            Assert.NotNull(fifteen);
            Assert.Equal(15, fifteen!.Data);

        }

        [Fact]
        public void UT014_AddAfter_Middle() {

            // Arrange
            _sut = new();
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(30);

            // Act
            _sut.AddAfter(25, 20);
            var twentyFive = _sut.FindAt(2);

            // Assert 
            Assert.NotNull(twentyFive);
            Assert.Equal(25, twentyFive!.Data);

        }

    }
}