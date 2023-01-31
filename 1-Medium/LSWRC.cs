namespace Medium;

/// <summary>
/// Longest Substring without repeating characters.
/// Note that substring is different than subsequence.
/// </summary>
public class LSWRC : IProblem{

    private List<HashSet<char>> Graph           { get; set; } = new();
    public int?                 Occurrences     { get; private set; }   = null;

    public void EntryPoint(){

        //string term = "abcabcbb";
        //string term = "bbbbb";
        string term = "pwwkew";

        Fill(term.ToCharArray());

        if(Occurrences.HasValue)
            Console.WriteLine("Total: {0}", Occurrences.Value);

        Graph.ForEach(
            node => Console.WriteLine(String.Join(",", node))
        );

    }

    private void Fill(char[] input){

        var branch = new HashSet<char>();
        int i; char t;

        for (i = 0; i < input.Length; i++) {
            t = input[i];
            if (branch.Contains(t)) break;
            branch.Add(t);
        }

        if (Occurrences.HasValue)
            Occurrences = Math.Max(Occurrences.Value, branch.Count);
        else
            Occurrences = branch.Count;

        Graph.Add(branch);

        if (!i.Equals(input.Length))
            Fill(input.Skip(i).ToArray());

    }
}
