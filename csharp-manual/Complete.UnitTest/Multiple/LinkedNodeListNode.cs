namespace Complete.UnitTest.Object.Multiple;

public partial class LinkedNodeList{
    public class Node { 

        private LinkedNodeList<string> _sut = new();

        [Fact]
        public void UT001_NoPeek() => Assert.False(_sut.HasPeek());

        [Fact]
        public void UT002_NoTail() => Assert.False(_sut.HasTail());
    
    }
}