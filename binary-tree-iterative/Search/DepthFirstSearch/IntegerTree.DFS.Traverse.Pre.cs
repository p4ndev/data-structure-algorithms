internal partial class IntegerTree {

    private void TraversePre()
    {
        _stack = new();
        _stack.Push(Root!);

        while (_stack.Count > 0)
        {
            _tmp = _stack.Pop();
            Output!.Add(_tmp.Data);

            if (_tmp.Right is not null)
                _stack.Push(_tmp.Right);

            if (_tmp.Left is not null)
                _stack.Push(_tmp.Left);
        }
    }

}