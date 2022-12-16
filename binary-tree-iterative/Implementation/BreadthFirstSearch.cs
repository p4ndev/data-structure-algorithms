internal partial class Tree {

    /// <summary>
    /// BFS = Largura de leitura de todos os nós em mesmo nível
    /// </summary>
    public void BreadthFirstSearch() {
        Queue<Node> queue = new();
        queue.Enqueue(Root!);

        while (!queue.Count.Equals(0)) {

            var tmp = queue.Dequeue();
            Console.Write(tmp.Data + " ");

            if (tmp.Left is not null)
                queue.Enqueue(tmp.Left);

            if (tmp.Right is not null)
                queue.Enqueue(tmp.Right);

        }

        Console.WriteLine();
    }

}