internal class Node{

    public int?     Data   { get; set; }
    public Node?    Left   { get; set; }
    public Node?    Right  { get; set; }
    
    public Node() { }

    public Node(int data) => Data = data;

    public void Print() {
        if(Data.HasValue)
            Console.Write(Data + " ");
    }

}
