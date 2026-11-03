internal partial class Node {

    public IDictionary<char, Node> Children { get; set; } = new Dictionary<char, Node>();

    public bool IsEndOfWord { get; set; }

}