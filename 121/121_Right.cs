
namespace Solution
{
    public class Solution121_Right
    {
        private int lowestPrice;
        private int maxProfit;

        public int MaxProfit(int[] prices)
        {
            lowestPrice = prices[0];
            maxProfit = 0;
            
            for (int i = 1; i < prices.Length; i++)
            {
                maxProfit = Math.Max(maxProfit, prices[i] - lowestPrice);
                lowestPrice = Math.Min(lowestPrice, prices[i]);
            }

            return maxProfit;
        }
        
    }
}