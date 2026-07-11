namespace LC1472;

public class DynamicArrayTests
{
    [Theory]
    [InlineData("leetcode.com", 1, true)]
    [InlineData("leetcode.com", 1, false)]
    [InlineData("leetcode.com", -1, true)]
    [InlineData("leetcode.com", -1, false)]
    [InlineData("leetcode.com", 5, true)]
    [InlineData("leetcode.com", 5, false)]
    [InlineData("leetcode.com", -5, true)]
    [InlineData("leetcode.com", -5, false)]
    public void Should_Return_Homepage_When_Navigate(string url, int steps, bool isBack = true)
    {
        // Arrange
        var browser = new Problems.LC1472.DynamicArray(url);

        // Act
        var result = (isBack ? browser.Back(steps) : browser.Forward(steps));

        // Assert
        Assert.Equal(url, result);
    }

    [Theory]
    [InlineData(new string[] { "google.com", "facebook.com", "youtube.com" }, 1, "facebook.com")]
    [InlineData(new string[] { "google.com", "facebook.com", "youtube.com", "linkedin.com" }, 1, "youtube.com")]
    [InlineData(new string[] { "google.com", "facebook.com", "youtube.com" }, 2, "google.com")]
    [InlineData(new string[] { "google.com", "facebook.com", "youtube.com", "linkedin.com" }, 4, "leetcode.com")]
    [InlineData(new string[] { "google.com", "facebook.com", "youtube.com", "linkedin.com" }, 8, "leetcode.com")]
    [InlineData(new string[] { "google.com", "facebook.com", "youtube.com" }, -1, "facebook.com")]
    [InlineData(new string[] { "google.com", "facebook.com", "youtube.com", "linkedin.com" }, -1, "youtube.com")]
    [InlineData(new string[] { "google.com", "facebook.com", "youtube.com" }, -2, "google.com")]
    [InlineData(new string[] { "google.com", "facebook.com", "youtube.com", "linkedin.com" }, -4, "leetcode.com")]
    [InlineData(new string[] { "google.com", "facebook.com", "youtube.com", "linkedin.com" }, -8, "leetcode.com")]
    public void Should_Navigate_Back(string[] urls, int steps, string expectation)
    {
        // Arrange
        var browser = new Problems.LC1472.DynamicArray("leetcode.com");
        
        foreach (var url in urls)
            browser.Visit(url);

        // Act
        var result = browser.Back(steps);

        // Assert
        Assert.Equal(expectation, result);
    }

    [Fact]
    public void Should_Throws_An_Invalid_Homepage_Exception()
    {
        // Act
        var exception = Assert.Throws<ArgumentException>(() => {
            _ = new Problems.LC1472.DynamicArray("");
        });

        // Assert
        Assert.Equal("Please provide a valid homepage", exception.Message);
    }

    [Fact]
    public void Should_Throws_An_Invalid_Url_Exception()
    {
        // Arrange
        var browser = new Problems.LC1472.DynamicArray("leetcode.com");

        // Act
        var exception = Assert.Throws<ArgumentException>(() => {
            browser.Visit(null!);
        });

        // Assert
        Assert.Equal("Please provide a valid url", exception.Message);
    }

    [Fact]
    public void Should_Navigate_Forward_After_Back()
    {
        // Arrange
        var browser = new Problems.LC1472.DynamicArray("leetcode.com");

        browser.Visit("google.com");
        browser.Visit("facebook.com");
        browser.Visit("youtube.com");

        browser.Back(1);

        // Act
        var result = browser.Forward(1);

        // Assert
        Assert.Equal("youtube.com", result);
    }

    [Fact]
    public void Should_Not_Go_Forward_Beyond_Last_Page()
    {
        // Arrange
        var browser = new Problems.LC1472.DynamicArray("leetcode.com");

        browser.Visit("google.com");
        browser.Visit("facebook.com");
        browser.Visit("youtube.com");

        // Act
        var firstResult = browser.Back(3);
        var secondResult = browser.Forward(10);

        // Assert
        Assert.Equal("leetcode.com", firstResult);
        Assert.Equal("youtube.com", secondResult);
    }

    [Fact]
    public void Visit_Should_Clear_Forward_History()
    {
        // Arrange
        var browser = new Problems.LC1472.DynamicArray("leetcode.com");

        browser.Visit("google.com");
        browser.Visit("facebook.com");

        var firstResult = browser.Back(1);

        browser.Visit("youtube.com");
        browser.Visit("linkedin.com");

        // Act
        var secondResult = browser.Forward(1);

        // Assert
        Assert.Equal("google.com", firstResult);
        Assert.Equal("linkedin.com", secondResult);
    }

    [Fact]
    public void Should_Handle_Official_Example()
    {
        // Arrange
        var browser = new Problems.LC1472.DynamicArray("leetcode.com");

        // Act
        browser.Visit("google.com");
        browser.Visit("facebook.com");
        browser.Visit("youtube.com");

        var firstResult = browser.Back(1);
        var secondResult = browser.Back(1);
        var thirdResult = browser.Forward(1);

        browser.Visit("linkedin.com");

        var fourthResult = browser.Forward(2);
        var fifthResult = browser.Back(2);
        var sixthResult = browser.Back(7);

        // Assert
        Assert.Equal("facebook.com", firstResult);
        Assert.Equal("google.com", secondResult);
        Assert.Equal("facebook.com", thirdResult);
        Assert.Equal("linkedin.com", fourthResult);
        Assert.Equal("google.com", fifthResult);
        Assert.Equal("leetcode.com", sixthResult);
    }
}