internal partial class IntegerTree {

    private void TraverseIn()
    {
        _stack = new();
        _tmp = Root;

        while (_tmp is not null || _stack.Count > 0)
        {
            while (_tmp is not null)
            {
                _stack.Push(_tmp);
                _tmp = _tmp.Left;
            }

            _tmp = _stack.Pop();
            Output!.Add(_tmp.Data);

            _tmp = _tmp.Right;
        }
    }

}