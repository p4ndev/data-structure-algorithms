//int Calculate(string s)
//{
//    int? acc = null;
//    Stack<string> storage = new();

//    for (int i = (s.Length - 1); i >= 0; i--)
//    {
//        if (Char.IsWhiteSpace(s[i]))
//            continue;

//        if (Attach(s[i], storage))
//            continue;

//        Evaluate(acc, storage);
//    }

//    Evaluate(acc, storage);

//    string? output;
//    storage.TryPop(out output);
//    return (output is null ? 0 : int.Parse(output));
//}

//bool Attach(char input, Stack<string> storage)
//{
//    if (Char.IsDigit(input) || input.Equals(')') || input.Equals('+') || input.Equals('-'))
//    {
//        storage.Push(input.ToString());
//        return true;
//    }

//    return false;
//}

//void Evaluate(int? acc, Stack<string> storage)
//{
//    int num = 0;
//    string? data;
//    bool? isSum = null;

//    while (storage.TryPop(out data))
//    {
//        switch (data)
//        {
//            case ")": break;
//            case " ": break;
//            case null: break;
//            case "+": isSum = true; break;
//            case "-": isSum = false; break;
//        }

//        if (!isSum.HasValue)
//            continue;

//        if (int.TryParse(data, out num))
//        {
//            if (!acc.HasValue)
//            {
//                acc = num;
//                continue;
//            }

//            if (isSum.Value) acc += num;
//            else acc -= num;
//        }
//    }

//    if (acc.HasValue)
//        storage.Push(acc.Value.ToString());

//    acc = null;
//    isSum = null;
//}

//string input;
//int output, expectation;

//input = "1 + 1";
//expectation = 2;
//output = Calculate(input);

//Console.WriteLine("Input: {0}", input);
//Console.WriteLine("Output: {0}", output);
//Console.WriteLine("Expectation: {0}", expectation);