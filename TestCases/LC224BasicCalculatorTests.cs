using Problems;

namespace TestCases
{
    public class LC224BasicCalculatorTests
    {
        private readonly LC224BasicCalculator _sut;

        // Arrange
        public LC224BasicCalculatorTests()
            => _sut = new();

        [Theory]
        [InlineData("1-(     -2)", 3)]
        [InlineData("1+(-2)", -1)]
        [InlineData("0-(-1)", 1)]
        [InlineData("-(1-(2+3))", 4)]
        [InlineData("-(2+3)", -5)]
        [InlineData("(-2+3)", 1)]
        [InlineData("(-2-3)", -5)]
        [InlineData("-2147483647", -2147483647)]
        [InlineData("(-123)", -123)]
        [InlineData("1 + 1", 2)]
        [InlineData("(1+(4+5+2)-3)+(6+8)", 23)]
        [InlineData(" 2-1 + 2 ", 3)]
        [InlineData(" 2-1 + 2 - 5 + 20 - 5 ", 13)]
        public void Calculate(string input, int expectation)
        {
            // Act
            var output = _sut.Calculate(input);

            // Assert
            Assert.Equal(expectation, output);
        }
    }
}
