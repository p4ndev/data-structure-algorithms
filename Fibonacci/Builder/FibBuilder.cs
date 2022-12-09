namespace Fibonacci.Builder;

internal class FibBuilder{

    private int _output;

    public void First(IFib instance) {
        _output = instance.ElementAt(0);
        Print();
    }

    public void Fourth(IFib instance) {
        _output = instance.ElementAt(3);
        Print();
    }

    public void Seventh(IFib instance) {
        _output = instance.ElementAt(6);
        Print();
    }

    public void Tenth(IFib instance) {
        _output = instance.ElementAt(9);
        Print();
    }

    public void NegativeSequence(IFib instance){
        try{
            _output = instance.ElementAt(-34);
        } catch (ArgumentException ae) {
            Console.WriteLine(ae.Message);
        }
    }

    public void ExceedSequence(IFib instance) {
        try{
            _output = instance.ElementAt(10);
        } catch (ArgumentException ae) {
            Console.WriteLine(ae.Message);
        }
    }

    private void Print() => Console.WriteLine(_output);

}
