
//// 1ms Runtime 88.45% Beats
//// 39.26Mb Memory 96.33% Beats

//using System.Text;

//string DecodeString(string s)
//{
//    if (string.IsNullOrWhiteSpace(s))
//        return s;

//    Stack<int> numbers = new();
//    Stack<StringBuilder> texts = new();

//    StringBuilder current = new();
//    int number = 0;

//    foreach (char c in s)
//    {
//        if (char.IsDigit(c))
//        {
//            number = number * 10 + (c - '0');
//            continue;
//        }

//        if (c == '[')
//        {
//            numbers.Push(number);
//            texts.Push(current);

//            current = new StringBuilder();
//            number = 0;
//            continue;
//        }

//        if (c == ']')
//        {
//            int repeat = numbers.Pop();
//            StringBuilder previous = texts.Pop();

//            for (int i = 0; i < repeat; i++)
//                previous.Append(current);

//            current = previous;
//            continue;
//        }

//        current.Append(c);
//    }

//    return current.ToString();
//}


































//using System.Text;

//// 2ms Runtime  43% Beats
//// 40Mb Memory   9% beats

//string DecodeString(string s)
//{
//    if (String.IsNullOrWhiteSpace(s))
//        return s;

//    Stack<int> n = new();
//    Stack<string> t = new();
//    StringBuilder sb = new();

//    int r;
//    string? tmp;

//    foreach (char l in s)
//    {
//        if (Char.IsDigit(l))
//        {
//            sb.Append(l);
//            continue;
//        }

//        if (sb.Length > 0)
//        {
//            n.Push(int.Parse(sb.ToString()));
//            sb.Clear();
//        }

//        if (!l.Equals(']'))
//        {
//            t.Push(l.ToString());
//            continue;
//        }

//        while (t.TryPop(out tmp))
//            if (!String.IsNullOrWhiteSpace(tmp))
//                if (!tmp.Equals("["))
//                    sb.Insert(0, tmp);
//                else
//                    break;

//        tmp = sb.ToString();
//        sb.Clear();

//        if (n.TryPop(out r))
//            while (r > 0)
//            {
//                sb.Append(tmp);
//                r--;
//            }

//        t.Push(sb.ToString());
//        sb.Clear();
//    }

//    sb.Clear();
//    while (t.TryPop(out tmp))
//        if (!String.IsNullOrWhiteSpace(tmp))
//            sb.Insert(0, tmp);

//    return sb.ToString();
//}











































































//void Execute(string input, string output, string expectation)
//{
//    Console.ForegroundColor = ConsoleColor.White;

//    Console.WriteLine("Input \t\t {0}", input);
//    Console.WriteLine("Output \t\t {0}", output);
//    Console.WriteLine("Expectation \t {0}", expectation);

//    var result = expectation.Equals(output);
//    Console.ForegroundColor = (result ? ConsoleColor.Green : ConsoleColor.Red);
//    Console.WriteLine("Is it valid? \t {0}\n", result);

//    Console.ForegroundColor = ConsoleColor.White;
//}

//string input = "", expectation = "", output = "";

//#region Edge cases

//input = "";
//expectation = "";
//output = DecodeString(input);
//Execute(input, output, expectation);

//input = " ";
//expectation = " ";
//output = DecodeString(input);
//Execute(input, output, expectation);

//#endregion

//#region Corner cases

//input = "abcabc";
//expectation = "abcabc";
//output = DecodeString(input);
//Execute(input, output, expectation);

//input = "[]";
//expectation = "";
//output = DecodeString(input);
//Execute(input, output, expectation);

//#endregion

//#region Simplest

//input = "4[a]3[bc]2[de]";
//expectation = "aaaabcbcbcdede";
//output = DecodeString(input);
//Execute(input, output, expectation);

//input = "3[a]";
//expectation = "aaa";
//output = DecodeString(input);
//Execute(input, output, expectation);

//input = "2[a]3[b]";
//expectation = "aabbb";
//output = DecodeString(input);
//Execute(input, output, expectation);

//input = "3[a2[c]]";
//expectation = "accaccacc";
//output = DecodeString(input);
//Execute(input, output, expectation);

//#endregion

//#region Complex

//input = "4[a3[b2[c]d]e]";
//expectation = "abccdbccdbccdeabccdbccdbccdeabccdbccdbccdeabccdbccdbccde";
//output = DecodeString(input);
//Execute(input, output, expectation);

//input = "5[a4[c3[d]]]2[ef]gh";
//expectation = "acdddcdddcdddcdddacdddcdddcdddcdddacdddcdddcdddcdddacdddcdddcdddcdddacdddcdddcdddcdddefefgh";
//output = DecodeString(input);
//Execute(input, output, expectation);

//input = "100[leetcode]";
//expectation = "leetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcodeleetcode";
//output = DecodeString(input);
//Execute(input, output, expectation);

//input = "2[abc]3[cd]ef";
//expectation = "abcabccdcdcdef";
//output = DecodeString(input);
//Execute(input, output, expectation);

//#endregion





























































//using System.Text;

//if (string.IsNullOrWhiteSpace(s) || s.IndexOf("]") == -1)
//    return s;

//Stack<string> storage = new();
//StringBuilder accumulator = new();

//for (int i = 0; i < s.Length; i++)
//{
//    switch (s[i])
//    {
//        case '[':
//            continue;

//        case ']':
//            if ((i + 1) < s.Length && !char.IsDigit(s[i + 1]) && s[i + 1] != ']')
//                storage.Push("1");
//            break;

//        case var c when char.IsDigit(c):
//            accumulator.Append(c);
//            break;

//        default:
//            if (accumulator.Length > 0)
//            {
//                storage.Push(accumulator.ToString());
//                accumulator.Clear();
//            }

//            storage.Push(s[i].ToString());
//            break;
//    }
//}

//accumulator.Clear();

//foreach (string item in storage)
//{
//    if (int.TryParse(item, out int num))
//    {
//        string term = accumulator.ToString();
//        while ((num - 1) > 0)
//        {
//            accumulator.Append(term);
//            num--;
//        }
//    }
//    else
//        accumulator.Insert(0, item);
//}

//return accumulator.ToString();























































/*
StringBuilder t = new(), n = new(), p = new();

for (int i = (s.Length - 1); i >= 0; i--)
{
    if (Char.IsDigit(s[i]))
    {
        int r = int.Parse(s[i].ToString()),
            j = (i + 2);
            
        t.Clear();      n.Clear();

        while (s[j] != ']')
        {
            t.Append(s[j]);
            j++;
        }

        while (r > 0)
        {
            n.Append(t);
            r--;
        }

        int l = (i - 1);    p.Clear();

        if (l >= 2)
        {
            p.Append(s.Substring(0, l + 1))
                .Append(n)
                    .Append(s.Substring(j + 1));

            s = p.ToString();
            i = s.Length;
        }
        else
        {
            p.Append(n)
                .Append(s.Substring(j + 1));

            s = p.ToString();
            break;
        }
    }
}

return s; 
*/