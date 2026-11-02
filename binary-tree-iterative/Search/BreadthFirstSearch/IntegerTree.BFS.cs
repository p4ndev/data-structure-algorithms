internal partial class IntegerTree {

    public IList<int> BreadthFirstSearch() {
        Output = new List<int>();
        
        if (Root is null)
            return Output;

        _queue = new();
        _queue.Enqueue(Root);

        while (_queue.Any()) {

            _tmp = _queue.Dequeue();
            Output.Add(_tmp.Data);

            if(_tmp.Left is not null)
                _queue.Enqueue(_tmp.Left);

            if(_tmp.Right is not null)
                _queue.Enqueue(_tmp.Right);
        }

        return Output;
    }

}