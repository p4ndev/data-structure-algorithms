namespace Problems;

public record Buyer(int Amount, bool Target = false);

public class LC2073
{
    /*
    Runtime     7ms             Beats 13.04%
    Memory      45.06 MB        Beats  8.21%
    https://leetcode.com/problems/time-needed-to-buy-tickets/submissions/2061167924
    */
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        if (k < 0 || tickets.Length == 0)
            return 0;

        if(tickets.Length == 1)
            return tickets[k];

        Queue<Buyer> storage = new();
        int seconds = 0, remaining;
        Buyer? buyer;

        for (int i = 0; i < tickets.Length; i++)
            storage.Enqueue(new(tickets[i], i == k));

        while (storage.TryDequeue(out buyer) && buyer is not null)
        {
            remaining = (buyer.Amount - 1);
            seconds++;

            if (remaining >= 1)
                storage.Enqueue(new(remaining, buyer.Target));
            else if (buyer.Target)
                break;
        }

        return seconds;
    }

    public int Extra_Space_For_Aux_Index_Best_Memory(int[] tickets, int k)
    {
        Queue<int> queue = new();
        
        for (int i = 0; i < tickets.Length; i++)
            queue.Enqueue(i);

        int seconds = 0;

        while (tickets[k] != 0)
        {
            int index = queue.Dequeue();
            
            if (--tickets[index] > 0)
                queue.Enqueue(index);

            seconds++;
        }

        return seconds;
    }

    public int No_Extra_Space_Pure_Math_Best_Runtime(int[] tickets, int k)
    {
        int totalTime = 0;

        for (int i = 0; i < tickets.Length; i++)
            if (i <= k)
                totalTime += Math.Min(tickets[i], tickets[k]);
            else
                totalTime += Math.Min(tickets[i], tickets[k] - 1);

        return totalTime;
    }
}
