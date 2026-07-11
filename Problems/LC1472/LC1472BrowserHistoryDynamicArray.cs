namespace Problems.LC1472;

/*
Problems.LC1472.DynamicArray obj = new(homepage);

obj.Visit(url);

string param_2 = obj.Back(steps);
string param_3 = obj.Forward(steps);
*/

public class DynamicArray
{
    private int _current = 0;
    private List<string> _storage = new();

    public DynamicArray(string homepage)
    {        
        if (!IsValid(homepage))
            throw new ArgumentException("Please provide a valid homepage");

        _storage.Add(homepage);
    }

    public void Visit(string url)
    {
        if (!IsValid(url))
            throw new ArgumentException("Please provide a valid url");

        int available = LastIndex();
        if (_current < available)
        {
            int starts = (_current + 1);
            int ends = (_storage.Count - _current - 1);
            _storage.RemoveRange(starts, ends);
        }

        _storage.Add(url);
        _current = LastIndex();
    }

    public string Back(int steps)
    {
        if(steps.Equals(0))
            return _storage.ElementAt(_current);

        int input = (steps < 0 ? steps : (steps * -1));
        
        return NavigateTo(input);
    }

    public string Forward(int steps)
    {
        if (steps.Equals(0))
            return _storage.ElementAt(_current);

        if (steps < 0)
            return Back(steps);

        return NavigateTo(steps);
    }

    private bool IsValid(string url)
        => !String.IsNullOrWhiteSpace(url);

    private int LastIndex()
        => (_storage.Count - 1);

    private string NavigateTo(int steps)
    {
        int firstIndex  = 0,
            nextIndex  = (steps + _current),
            lastIndex   = (_storage.Count - 1);

        switch (nextIndex)
        {
            case var cr when cr.Equals(_current):
                break;

            case var fi when fi <= firstIndex:
                _current = firstIndex;
                break;

            case var li when li >= lastIndex:
                _current = lastIndex;
                break;

            default:
                _current = nextIndex;
                break;
        }

        return _storage.ElementAt(_current);
    }
}