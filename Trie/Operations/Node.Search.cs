internal partial class Node {

    public bool Search(string word)
    {
        Node current = this;

        foreach (char c in word)
        {
            if (!current.Children.TryGetValue(c, out Node? child))
                return false;

            current = child;
        }

        return current.IsEndOfWord;
    }

}