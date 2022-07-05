using System.Diagnostics;

namespace CrossCuttings;

public class ExecutionTimer{

    private readonly Stopwatch _timer;

    public ExecutionTimer()     => _timer = new();

    public double Milliseconds()  => _timer.Elapsed.TotalMilliseconds;

    public void Run<T>(Action<T> fnc, T parameters) {
        _timer.Restart();
        fnc(parameters);
        _timer.Stop();
    }

}
