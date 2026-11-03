internal partial class Node {

    public void Fill(string word)
    {
        Node current = this;

        foreach (char c in word)
        {
            if (!current.Children.ContainsKey(c))
                current.Children[c] = new Node();

            current = current.Children[c];
        }

        current.IsEndOfWord = true;
    }

}