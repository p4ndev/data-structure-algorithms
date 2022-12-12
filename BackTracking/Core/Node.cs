namespace Maze;

public sealed class Node{

    public int              Data        { get; private set; }
    public Categorization   Category    { get; private set; }
    
    public bool             HasVisited  { get; set; }

    public Node?            Left        { get; private set; }
    public Node?            Right       { get; private set; }

    public Node() => Category = Categorization.None;

    public Node(int term) : base() => Data = term;

    public void AddLeft(int term) {
        Left = Helper.CreateNode(term);
        Handle();
    }

    public void AddRight(int term) {
        Right = Helper.CreateNode(term);
        Handle();
    }

    private void Handle() {
        
        if (Left is null && Right is null)
            Category = Categorization.None;

        if (Left is null || Right is null)
            Category = Categorization.Half;

        if (Left is not null && Right is not null)
            Category = Categorization.Full;

    }

}