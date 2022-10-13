namespace hacker_rank;

internal class Node{

    public int? Data { get; set; }

    public Node? Left { get; set; }

    public Node? Right { get; set; }

    public void Print() {
        if(Data.HasValue)
            Console.Write(Data + " ");
    }

}
