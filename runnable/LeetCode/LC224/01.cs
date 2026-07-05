//using System.Text;

//int Calculate(string s)
//{
//    string? tmp;
//    int i, output = 0;
//    bool? isSum = null;
//    StringBuilder sb = new();
//    Stack<string> storage = new();

//    #region Plain numbers and signals
//    for (i = (s.Length - 1); i >= 0; i--)
//    {
//        if (s[i].Equals('(') || s[i].Equals(')') || s[i].Equals(' '))
//            continue;

//        if (s[i] == '+' || s[i] == '-')
//        {
//            storage.Push(sb.ToString());
//            storage.Push(s[i].ToString());
//            sb.Clear();
//            continue;
//        }

//        sb.Insert(0, s[i]);
//    }
//    storage.Push(sb.ToString());
//    sb.Clear();
//    #endregion

//    i = 0;

//    #region Calculate
//    while (storage.TryPop(out tmp))
//    {
//        if (output == 0 && int.TryParse(tmp, out output))
//            continue;

//        if (i == 0 && int.TryParse(tmp, out i))
//            continue;

//        if (isSum.HasValue)
//        {
//            if (isSum.Value) output += i;
//            else output -= i;

//            i = 0;
//            isSum = null;
//            storage.Push(tmp);
//            continue;
//        }

//        if (tmp.Equals("+"))
//        {
//            isSum = true;
//            continue;
//        }
//        else if (tmp.Equals("-"))
//        {
//            isSum = false;
//            continue;
//        }
//    }

//    if (isSum.HasValue)
//    {
//        if (isSum.Value) output += i;
//        else output -= i;
//    }
//    #endregion

//    return output;
//}

//string input;
//int output, expectation;

//input = "35 + 25 - (8 - 3) + 2";
//output = Calculate(input);
//expectation = 57;

//Console.WriteLine("Input: {0}", input);
//Console.WriteLine("Expectation: {0}", expectation);
//Console.WriteLine("Output: {0}", output);
