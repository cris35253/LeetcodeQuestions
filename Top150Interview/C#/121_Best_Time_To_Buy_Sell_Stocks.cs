public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int left = 0;   // buy day
        int right = 1;  // sell day
        int maxP = 0;

        while (right < prices.Length)
        {
            if (prices[left] < prices[right])
            {
                int profit = prices[right] - prices[left];
                if (profit > maxP) maxP = profit;
            }
            else
            {
                left = right;
            }
            right++;
        }
        return maxP;
    }
}