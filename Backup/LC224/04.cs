//int Calculate(string s) {

//    string data;
//    int? inner = null;
//    bool? isSum = null;
//    Stack<string> storage = new();

//    s = s.Trim();

//    for (int i = (s.Length - 1); i >= 0; i--)
//    {
//        switch(s[i])
//        {
//            case var c when Char.IsDigit(c):
//            case ')':
//            case '+':
//            case '-':
//                storage.Push(s[i].ToString());
//                break;

//            case '(':
//                while (storage.Peek() != ")")
//                {
//                    data = storage.Pop();
//                    switch (data) {
//                        case "+": isSum = true; break;
//                        case "-": isSum = false; break;
//                        default:
//                            int dataNum = Convert.ToInt32(data);
//                            if (!inner.HasValue)
//                                inner = dataNum;
//                            else if (isSum.HasValue)
//                            {
//                                if (isSum.Value)    inner += dataNum;
//                                else                inner -= dataNum;
//                            }
//                            break;
//                    }
//                }

//                storage.Pop();
//                storage.Push(inner!.Value.ToString());

//                inner = null;
//                isSum = null;

//                break;
//        }
//    }

//    return Convert.ToInt32(storage.Pop());

//}