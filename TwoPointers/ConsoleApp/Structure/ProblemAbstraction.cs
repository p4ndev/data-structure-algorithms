public abstract class ProblemAbstraction<TIn, TOut, TExp>
{
    protected TIn Input { get; set; }
    protected TOut Output { get; set; }
    protected TExp Expected { get; set; }
    
    protected virtual void Review()
    {
        Console.ForegroundColor = (Expected!.Equals(Output) ? ConsoleColor.Green : ConsoleColor.Red);
        Console.WriteLine(Output);
    }

    public void Reset()
    {
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.White;
    }
}