namespace Problems;

public class LC121
{
    public int MaxProfit(int[] prices)
    {
        // Dynamic Programming

        int min = int.MaxValue, max = 0;

        foreach (int p in prices)
        {
            min = Math.Min(min, p);
            int profit = p - min;
            max = Math.Max(max, profit);
        }

        return max;
    }
}

#region Two pointers
/*
int left = 0, right = 1, max = 0;

while (right < prices.Length)
{
    if (prices[left] < prices[right])
    {
        int profit = prices[right] - prices[left];
        max = Math.Max(max, profit);
    }
    else
        left = right;

    right++;
}

return max; 
*/
#endregion

#region Brute force
/*
if (prices == null || prices.Length <= 1)
    return 0;

int maxProfit = 0;

for (int i = 0; i < prices.Length - 1; i++)
    for (int j = i + 1; j < prices.Length; j++)
    {
        int profit = prices[j] - prices[i];

        if (profit > maxProfit)
            maxProfit = profit;
    }

return maxProfit; 
*/
#endregion