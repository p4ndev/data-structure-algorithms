namespace Problems;

public class LC1472
{
    private string _tmp;

    public LC1472(string homepage)
    {
        _tmp = homepage;
    }

    public void Visit(string url)
    {
        
    }

    public string Back(int steps)
    {
        return _tmp;
    }

    public string Forward(int steps)
    {
        return _tmp;
    }
}

/*
 LC1472 obj = new LC1472(homepage);
 obj.Visit(url);
 string param_2 = obj.Back(steps);
 string param_3 = obj.Forward(steps);
*/