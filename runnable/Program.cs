string input = "1-(     -2)"; // OUTPUT (Incorrect): -1
int output = Calculate(input), expectation = 3;

//string input = "(-2+3)"; // OUTPUT (Incorrect): -1
//int output = Calculate(input), expectation = 1;

//string input = "(-2-3)"; // OUTPUT (Incorrect): -5
//int output = Calculate(input), expectation = -5;

//string input = "1+(-2)"; // OUTPUT (Incorrect): 3
//int output = Calculate(input), expectation = -1;

//string input = "-(2+3)"; // OUTPUT (Incorrect): 5
//int output = Calculate(input), expectation = -5;

//string input = "-(1-(2+3))"; // OUTPUT (Incorrect): -4
//int output = Calculate(input), expectation = 4;

//string input = "-2147483647"; // OUTPUT (Incorrect): 2147483647
//int output = Calculate(input), expectation = -2147483647;

//string input = "0-(-1)"; // OUTPUT (Incorrect): -1
//int output = Calculate(input), expectation = 1;

//string input = "(-123)"; // OUTPUT (Incorrect): 123
//int output = Calculate(input), expectation = -123;

Console.WriteLine("Input: {0}\nOutput: {1}\nExpectation: {2}", input, output, expectation);

/***********************************************************************************************************************/
/***********************************************************************************************************************/
/***********************************************************************************************************************/

void PersistPendingData(Stack<string> storage, System.Text.StringBuilder sb) {
    if (sb.Length <= 0)
        return;

    storage.Push(sb.ToString());
    sb.Clear();
}

void FillOperations(Stack<string> storage, Queue<int> numbers, Queue<bool> sumOperations)
{
    while (storage.TryPop(out string? term) && !term.Equals(")"))
        switch (term)
        {
            case "+":   sumOperations.Enqueue(true);                break;
            case "-":   sumOperations.Enqueue(false);               break;
            default:    numbers.Enqueue(Convert.ToInt32(term));     break;
        }
}

void SolveOperations(Stack<string> storage, Queue<int> numbers, Queue<bool> sumOperations)
{
    bool isSum;
    int left = numbers.Dequeue(), right;
    
    while(numbers.TryDequeue(out right))
        if(sumOperations.TryDequeue(out isSum))
            switch (isSum)
            {
                case true:
                    left += right;
                    break;

                case false:
                    left -= right;
                    break;
            }

    storage.Push(left.ToString());
}

/***********************************************************************************************************************/
/***********************************************************************************************************************/
/***********************************************************************************************************************/

int Calculate(string s)
{
    if (String.IsNullOrWhiteSpace(s))
        return default;

    #region Declaration
    char input;

    System.Text.StringBuilder sb = new();
    Stack<string> storage = new();

    Queue<int> numbers = new();
    Queue<bool> sumOperations = new();
    #endregion

    for (int i = (s.Length - 1); i >= 0; i--)
    {
        input = s[i];

        switch(input)
        {
            case var c when Char.IsWhiteSpace(c):
                PersistPendingData(storage, sb);
                break;

            case var d when Char.IsDigit(d):
                sb.Insert(0, input);
                break;

            case ')':
            case '+':
            case '-':
                PersistPendingData(storage, sb);
                storage.Push(input.ToString());
                break;

            case '(':
                numbers.Clear();
                sumOperations.Clear();

                PersistPendingData(storage, sb);
                FillOperations(storage, numbers, sumOperations);
                SolveOperations(storage, numbers, sumOperations);
                break;
        }
    }

    PersistPendingData(storage, sb);

    if (storage.Count > 1)
    {
        numbers.Clear();
        sumOperations.Clear();

        FillOperations(storage, numbers, sumOperations);
        SolveOperations(storage, numbers, sumOperations);
    }
    
    return Convert.ToInt32(storage.Pop());
}