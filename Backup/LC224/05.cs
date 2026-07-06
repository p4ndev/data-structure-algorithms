
//if (sumOperations.Count.Equals(1) && sumOperations.Peek().Equals(false))
//{
//    currentNumber *= -1;
//    sumOperations.Dequeue();

//    if (storage.TryPop(out term) && (term!.Equals("+") || term!.Equals("-")))
//        sumOperations.Enqueue(term.Equals("+"));
//    else
//        sumOperations.Enqueue(true);
//}







//bool isSum;



//if (sumOperations.TryDequeue(out isSum))
//{
//    switch (isSum)
//    {
//        case true:
//            left += right;
//            break;

//        case false:
//            left -= right;
//            break;
//    }
//}
//else
//    left += right;