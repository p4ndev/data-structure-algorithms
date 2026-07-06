////string input = "15 + 5 - (8 - 3)"; // 15
//string input = "(15 + 5 - (8 - 3))"; // 15
//int output = Calculate(input);

//Console.WriteLine(input);
//Console.WriteLine(output);


//void Evaluate(Stack<string> storage)
//{
//    string? term;
//    bool? isSum = null;
//    int left = 0, right = 0;
    
//    while (storage.TryPop(out term) && !String.IsNullOrEmpty(term))
//    {
//        if (isSum.HasValue && !left.Equals(0) && !right.Equals(0))
//        {
//            if (isSum.Value) left += right;
//            else if (!isSum.Value) left -= right;
            
//            if (term.Equals("+"))
//                isSum = true;
//            else if (term.Equals("-"))
//                isSum = false;
            
//            right = 0;
//            continue;
//        }
        
//        if(left.Equals(0) && int.TryParse(term, out left))
//            continue;
        
//        if(right.Equals(0) && int.TryParse(term, out right))
//            continue;
        
//        if (term.Equals("+"))
//            isSum = true;
//        else if (term.Equals("-"))
//            isSum = false;
//    }
    
//    storage.Push(left.ToString());
//}

//int Calculate(string s)
//{
//    char current;
//    System.Text.StringBuilder acc = new();
//    Stack<string> storage = new();

//    for (int i = (s.Length - 1); i >= 0; i--)
//    {
//        current = s[i];

//        switch (current)
//        {
//            case ' ':
//                break;
         
//            case '(':
//                storage.Push(acc.ToString());
//                acc.Clear();
//                Evaluate(storage);
//                break;
            
//            case var n when char.IsDigit(n):
//                acc.Insert(0, current);
//                break;
            
//            case '+':
//            case '-':
//                if(!String.IsNullOrEmpty(acc.ToString()))
//                    storage.Push(acc.ToString());
//                storage.Push(current.ToString());
//                acc.Clear();
//                break;
            
//            case ')':
//                storage.Push(current.ToString());
//                break;
//        }
//    }

//    if (acc.Length > 0)
//    {
//        storage.Push(acc.ToString());
//        acc.Clear();
//    }
    
//    return 15;
//}