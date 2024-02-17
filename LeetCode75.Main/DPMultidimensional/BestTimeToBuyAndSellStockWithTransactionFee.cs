namespace LeetCode75.Main.DPMultidimensional;

internal class BestTimeToBuyAndSellStockWithTransactionFee
{
    public int MaxProfit(int[] prices, int fee)
    {
        if (prices.Length <= 1)
        {
            return 0;
        }

        int saving = -prices[0];
        int profit = 0;
        
        for (int i = 1; i < prices.Length; i++)
        {
            profit = Math.Max(profit, saving + prices[i] - fee);
            saving = Math.Max(saving, profit - prices[i]);
        }

        return profit;
    }
}
