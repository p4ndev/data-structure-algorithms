namespace Complete.UnitTest.Operations;

public partial class Update{
    public class Data { 

        private LinkedNodeList<int>? _sut;

        public Data() => Fill();

        private void Fill() {
            _sut = new();
            _sut.AddFirst(10);
            _sut.AddLast(20);
            _sut.AddLast(30);
            _sut.AddLast(40);
            _sut.AddLast(50);
        }

        [Fact]
        public void UT001_Head() {

            // Arrange
            _sut!.Update(10, 15);

            // Act
            var first = _sut!.First();

            // Assert
            Assert.NotNull(first);
            Assert.Equal(15, first!.Data);

        }

        [Fact]
        public void UT002_Tail() {

            // Arrange
            _sut!.Update(50, 55);

            // Act
            var last = _sut!.Last();

            // Assert
            Assert.NotNull(last);
            Assert.Equal(55, last!.Data);

        }

        [Fact]
        public void UT003_Middle(){

            // Arrange
            _sut!.RemoveLast();
            _sut!.RemoveLast();
            var last = _sut!.Last();

            // Act
            _sut!.Update(30, 35);

            // Assert
            Assert.NotNull(last);
            Assert.Equal(35, last!.Data);

        }

        [Fact]
        public void UT004_Head_Update() {

            // Act
            _sut!.UpdateFirst(15);

            // Assert 
            Assert.Equal(15, _sut!.First()!.Data);

        }

        [Fact]
        public void UT005_Tail_Update(){

            // Act
            _sut!.UpdateLast(55);

            // Assert 
            Assert.Equal(55, _sut!.Last()!.Data);

        }

        [Fact]
        public void UT006_Head_EmptyUpdate() {

            // Arrange
            _sut = new();

            // Act
            _sut!.UpdateFirst(15);

            // Assert 
            Assert.False(_sut!.HasPeek());

        }

        [Fact]
        public void UT007_Tail_EmptyUpdate() {

            // Arrange
            _sut = new();

            // Act
            _sut!.UpdateLast(55);

            // Assert 
            Assert.False(_sut!.HasTail());

        }

        [Fact]
        public void UT008_InitialAt() {
            
            // Arrange
            Fill();

            // Act
            var result = _sut!.UpdateAt(100, 0);
            var entry = _sut!.Find(100);
            var emptyEntry = _sut!.Find(10);

            // Assert 
            Assert.True(result);
            Assert.Null(emptyEntry.Item);
            Assert.NotNull(entry.Item);
            Assert.Equal(0, entry.Index);

        }

        [Fact]
        public void UT009_MiddleAt() {

            // Arrange
            Fill();

            // Act
            var result = _sut!.UpdateAt(300, 2);
            var entry = _sut!.Find(300);
            var emptyEntry = _sut!.Find(30);

            // Assert 
            Assert.True(result);
            Assert.Null(emptyEntry.Item);
            Assert.NotNull(entry.Item);
            Assert.Equal(2, entry.Index);

        }

        [Fact]
        public void UT010_EndAt() {

            // Arrange
            Fill();

            // Act
            var result = _sut!.UpdateAt(500, 4);
            var entry = _sut!.Find(500);
            var emptyEntry = _sut!.Find(50);

            // Assert 
            Assert.True(result);
            Assert.Null(emptyEntry.Item);
            Assert.NotNull(entry.Item);
            Assert.Equal(4, entry.Index);

        }

        [Fact]
        public void UT011_Reverse() {

            // Arrange            
            Fill();

            // Act
            var first       = _sut!.FindAt(0)!.Data;
            var middle      = _sut!.FindAt(2)!.Data;
            var last        = _sut!.FindAt(4)!.Data;

            _sut!.Reverse();

            var _first      = _sut!.FindAt(0)!.Data;
            var _middle     = _sut!.FindAt(2)!.Data;
            var _last       = _sut!.FindAt(4)!.Data;

            // Assert 
            Assert.Equal(10, first);
            Assert.Equal(30, middle);
            Assert.Equal(50, last);

            Assert.Equal(50, _first);
            Assert.Equal(30, _middle);
            Assert.Equal(10, _last);

        }

    }
}