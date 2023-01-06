namespace Hard;

/// <summary>
/// Implement a basic calculator to evaluate a simple expression based on a string.
/// <para>The expression string may contain:</para>
/// <list type="bullet">
///    <item>Open ( and closing parentheses )</item>
///    <item>The minus -</item>
///    <item>The plus sign +</item>
///    <item>Non-negative integers</item>
///    <item>Lastly empty spaces .</item>
/// </list>
/// You may assume that given expression is always valid.
/// <list type="bullet">
///    <item>I/P: <c>"1 + 1"</c><para>O/P: <c>2</c></para></item>
///    <item>I/P: <c>" 2-1 + 2"</c><para>O/P: <c>3</c></para></item>
///    <item>I/P: <c>"(1+(4+5+2)-3)+(6+8)"</c><para>O/P: <c>23</c></para></item>
/// </list>
/// <para>Do not use the <c>eval()</c> built-in library method/function</para>
/// </summary>
public class BasicCalculator : IProblem{

    private bool _isSum = true;
    private System.Text.StringBuilder _sb = new();

    public void EntryPoint(){

        string input = "(1+(4+5+2)-3)+(6+8)-3";
        int output = Total(input);
        
        Display.Out(input);
        Display.Out(output, 20);

    }

    private bool ShouldSkip(char current) {
        
        // Throughout the sum operation (with negative or positive),
        // the spaces and parentheses don't infer anything.

        if (current.Equals(' ') || current.Equals('(') || current.Equals(')'))
            return true;
        return false;

    }

    private void Resume(char next, ref int acc) {
        
        int temp = int.Parse(_sb.ToString());
        acc = _isSum ? (acc + temp) : (acc - temp);

        _isSum = next.Equals('+');
        _sb.Clear();

    }

    public int Total(string sentence) {

        int acc = 0;

        foreach (char l in sentence) {
            
            if (ShouldSkip(l)) continue;

            if (Char.IsDigit(l)) {
                _sb.Append(l);
                continue;
            }

            Resume(l, ref acc);

        }

        if (_sb.Length > 0) Resume('+', ref acc);

        return acc;

    }

}
