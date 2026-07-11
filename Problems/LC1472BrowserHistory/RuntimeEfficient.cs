//public class BrowserHistory
//{
//    Node curr = null;
//    public BrowserHistory(string homepage)
//    {
//        curr = new Node(homepage);
//    }

//    public void Visit(string url)
//    {
//        Node node = new Node(url);
//        node.prev = curr;
//        curr.next = node;
//        curr = curr.next;
//    }

//    public string Back(int steps)
//    {
//        int i = 1;
//        while (curr.prev != null && i <= steps)
//        {
//            curr = curr.prev;
//            i++;
//        }
//        return curr.data;
//    }

//    public string Forward(int steps)
//    {
//        int i = 1;
//        while (curr.next != null && i <= steps)
//        {
//            curr = curr.next;
//            i++;
//        }
//        return curr.data;
//    }
//}

//public class Node
//{
//    public string data;
//    public Node next;
//    public Node prev;

//    public Node(string data)
//    {
//        this.data = data;
//        next = null;
//        prev = null;
//    }
//}