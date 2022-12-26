public class SlidingWindow<T> where T : IPairs, new(){

    private readonly int[]  _input;
    private readonly T      _instance;
    private readonly int    _blockSize;
    private readonly int    _totalPairs;

    public SlidingWindow(int[] input, int blockSize){

        _blockSize = blockSize;
        if (_blockSize <= 1)
            throw new InvalidOperationException("Pairs should have at least two elements.");

        _instance   = new();
        _input      = input;
        _totalPairs = (_input.Length - blockSize + 1);

    }

    public int[] Get => _instance.Find(_input, _blockSize, _totalPairs);

}