//public class BrowserHistory
//{
//    private List<string> urls;
//    private int currIndex;

//    public BrowserHistory(string homepage)
//    {
//        urls = new List<string>();
//        urls.Add(homepage);
//        currIndex = 0;
//    }

//    public void Visit(string url)
//    {
//        urls = urls.Take(currIndex + 1).ToList();
//        urls.Add(url);
//        currIndex++;
//    }

//    public string Back(int steps)
//    {
//        currIndex = Math.Max(currIndex - steps, 0);
//        return urls[currIndex];
//    }

//    public string Forward(int steps)
//    {
//        currIndex = Math.Min(currIndex + steps, urls.Count - 1);
//        return urls[currIndex];
//    }
//}