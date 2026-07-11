namespace LC1472;

public class BrowserHistoryTests
{
    /*
    Input:
    ["BrowserHistory",  "visit",        "visit",            "visit",            "back",         "back",         "forward",          "visit",            "forward",          "back",             "back"]
    [["leetcode.com"],  ["google.com"], ["facebook.com"],   ["youtube.com"],    [1],            [1],            [1],                ["linkedin.com"],   [2],                [2],                [7]]

    Output:
    [null,              null,           null,               null,               "facebook.com", "google.com",   "facebook.com",     null,               "linkedin.com",     "google.com",       "leetcode.com"]

    Explanation:
    BrowserHistory browserHistory = new BrowserHistory("leetcode.com");
    browserHistory.visit("google.com");       // You are in "leetcode.com". Visit "google.com"
    browserHistory.visit("facebook.com");     // You are in "google.com". Visit "facebook.com"
    browserHistory.visit("youtube.com");      // You are in "facebook.com". Visit "youtube.com"
    browserHistory.back(1);                   // You are in "youtube.com", move back to "facebook.com" return "facebook.com"
    browserHistory.back(1);                   // You are in "facebook.com", move back to "google.com" return "google.com"
    browserHistory.forward(1);                // You are in "google.com", move forward to "facebook.com" return "facebook.com"
    browserHistory.visit("linkedin.com");     // You are in "facebook.com". Visit "linkedin.com"
    browserHistory.forward(2);                // You are in "linkedin.com", you cannot move forward any steps.
    browserHistory.back(2);                   // You are in "linkedin.com", move back two steps to "facebook.com" then to "google.com". return "google.com"
    browserHistory.back(7);                   // You are in "google.com", you can move back only one step to "leetcode.com". return "leetcode.com" 
    */

    [Fact(Skip = "Not implemented yet")]
    public void Should_Handle_Official_Example()
    {
        // Arrange
        var browser = new Problems.LC1472("leetcode.com");

        // Act
        browser.Visit("google.com");
        browser.Visit("facebook.com");
        browser.Visit("youtube.com");

        var back1 = browser.Back(1);
        var back2 = browser.Back(1);
        var forward = browser.Forward(1);

        browser.Visit("linkedin.com");

        var forward2 = browser.Forward(2);

        var back3 = browser.Back(2);
        var back4 = browser.Back(7);

        // Assert
        Assert.Equal("facebook.com", back1);
        Assert.Equal("google.com", back2);
        Assert.Equal("facebook.com", forward);
        Assert.Equal("linkedin.com", forward2);
        Assert.Equal("google.com", back3);
        Assert.Equal("leetcode.com", back4);
    }

    [Fact]
    public void Should_Return_Homepage_When_Initialized_And_Back()
    {
        // Arrange
        var browser = new Problems.LC1472("leetcode.com");

        // Act
        var result = browser.Back(1);

        // Assert
        Assert.Equal("leetcode.com", result);
    }

    [Fact]
    public void Should_Return_Homepage_When_Initialized_And_Forward()
    {
        // Arrange
        var browser = new Problems.LC1472("leetcode.com");

        // Act
        var result = browser.Forward(1);

        // Assert
        Assert.Equal("leetcode.com", result);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Navigate_Back_To_Previous_Page()
    {
        // Arrange
        var browser = new Problems.LC1472("leetcode.com");

        browser.Visit("google.com");
        browser.Visit("facebook.com");
        browser.Visit("youtube.com");

        // Act
        var result = browser.Back(1);

        // Assert
        Assert.Equal("facebook.com", result);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Navigate_Back_Multiple_Steps()
    {
        // Arrange
        var browser = new Problems.LC1472("leetcode.com");

        browser.Visit("google.com");
        browser.Visit("facebook.com");
        browser.Visit("youtube.com");

        // Act
        var result = browser.Back(2);

        // Assert
        Assert.Equal("google.com", result);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Not_Go_Back_Beyond_Homepage()
    {
        // Arrange
        var browser = new Problems.LC1472("leetcode.com");

        browser.Visit("google.com");

        // Act
        var result = browser.Back(10);

        // Assert
        Assert.Equal("leetcode.com", result);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Navigate_Forward_After_Back()
    {
        // Arrange
        var browser = new Problems.LC1472("leetcode.com");

        browser.Visit("google.com");
        browser.Visit("facebook.com");

        browser.Back(1);

        // Act
        var result = browser.Forward(1);

        // Assert
        Assert.Equal("facebook.com", result);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Should_Not_Go_Forward_Beyond_Last_Page()
    {
        // Arrange
        var browser = new Problems.LC1472("leetcode.com");

        browser.Visit("google.com");

        browser.Back(1);

        // Act
        var result = browser.Forward(10);

        // Assert
        Assert.Equal("google.com", result);
    }

    [Fact(Skip = "Not implemented yet")]
    public void Visit_Should_Clear_Forward_History()
    {
        // Arrange
        var browser = new Problems.LC1472("leetcode.com");

        browser.Visit("google.com");
        browser.Visit("facebook.com");

        browser.Back(1);

        browser.Visit("amazon.com");

        // Act
        var result = browser.Forward(1);

        // Assert
        Assert.Equal("amazon.com", result);
    }
}