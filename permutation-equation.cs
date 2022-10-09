
PermutationEquation(
    new List<int>() { 2, 3, 1 }
).ForEach(Console.WriteLine); // 2, 3, 1

Console.WriteLine("------------------------------");

PermutationEquation(
    new List<int>() { 4, 3, 5, 1, 2 }
).ForEach(Console.WriteLine); // 1, 3, 5, 4, 2

// ========================================================================

static List<int> PermutationEquation(List<int> p){

    List<int> result = new List<int>();
    var store = new SortedDictionary<int, int>();

    for (int i = 0; i < p.Count; i++)
        store.Add(p[i], i + 1);

    for (int root = 1; root <= p.Count; root++){
        int first  = store[root];
        int second = store[first];
        result.Add(second);
    }

    return result;

}
