
//var inp = 5;
//var res = Decimal2Binary(inp);
//var str = new System.Text.StringBuilder();

//if (res is not null)
//    foreach (var item in res)
//        str.Append(item);

//Console.WriteLine(str.ToString());
//Console.WriteLine(IsBinary(inp.ToString()));
//Console.WriteLine(IsBinary(str.ToString()));
//Console.WriteLine(IsBinary("000111120001"));

//BitWiseOperations_v1();
//BitWiseOperations_v2();

// =======================================================

static IList<int>? Decimal2Binary(int val){

    if (val <= 0) return null;
    var store = new Stack<int>();
    
    while (val >= 1) {
        int rem  = (val % 2);
        val /= 2;
        store.Push(rem);
    }

    return store.ToList();

}

static bool IsBinary(string inp) {    
    foreach (var num in inp.ToCharArray())
        if (!num.Equals('0') && !num.Equals('1'))
            return false;

    return true;
}

static void BitWiseOperations_v1(){

    int a = 10, b = 12, c;
    string _a = Convert.ToString(a, 2); // 1010
    string _b = Convert.ToString(b, 2); // 1100
    Console.WriteLine("a = {0} \t\t b = {1}", _a, _b);

    // ========== SOMA BINARIA ============
    c = (a | b); // 1110 ...... | ou
    Console.WriteLine("(a | b) = {0} ({1})", c, Convert.ToString(c, 2));

    c = (a & b); // 1000 ...... & e
    Console.WriteLine("(a & b) = {0} ({1})", c, Convert.ToString(c, 2));

}

static void BitWiseOperations_v2() {

    byte a = 10;
    Console.WriteLine("INPUT: {0} ({1})", a, Convert.ToString(a, 2));

    // ============================ Right shift ==============================
    long r = (a >> 1);
    Console.WriteLine("RIGHT: {0} ({1})", r, Convert.ToString(r, 2));
    // Mover todos os bits para direita, parece que desconsideramos o primeiro

    // ============================ Left shift ==============================
    r = (a << 1);
    Console.WriteLine("LEFT: {0} ({1})", r, Convert.ToString(r, 2));
    // Mover todos os bits para esquerda, assim completamos com 0 para novos números

}
