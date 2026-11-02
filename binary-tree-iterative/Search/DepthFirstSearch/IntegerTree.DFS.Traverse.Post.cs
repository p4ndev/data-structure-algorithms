internal partial class IntegerTree {

    private void TraversePost()
    {
        _stack = new();
        Stack<Node<int>> visited = new();

        _stack.Push(Root!);

        while (_stack.Count > 0)
        {
            _tmp = _stack.Pop();
            visited.Push(_tmp);

            if (_tmp.Left is not null)
                _stack.Push(_tmp.Left);

            if (_tmp.Right is not null)
                _stack.Push(_tmp.Right);
        }

        while (visited.Count > 0)
            Output!.Add(visited.Pop().Data);
    }

}