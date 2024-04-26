
namespace Solution
{
    public class Solution121_Me
    {
        private int leftMin = -1;
        private int rightMax = -1;
        private int maxProfit = 0;
        private bool isLeftMinZero = false;
        
        public int MaxProfit(int[] prices)
        {
            leftMin = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                FindMinBeforeX(prices, i);

                FindMaxAfterX(prices, i);
                maxProfit = Math.Max(rightMax - leftMin, maxProfit);
                if (isLeftMinZero)
                {
                    break;
                }
            }
            
            return maxProfit;
        }

        public void FindMinBeforeX(int[] nums, int rightBound)
        {
            if (!isLeftMinZero)
            {
                if (nums[rightBound] == 0)
                {
                    isLeftMinZero = true;
                    leftMin = 0;
                    return;
                }
            
                leftMin = leftMin < nums[rightBound] ? leftMin : nums[rightBound];
            }
            
        }

        public void FindMaxAfterX(int[] nums, int leftBound)
        {
                if (rightMax == -1 || rightMax == nums[leftBound - 1])
                {
                    rightMax = -1;
                    for (int i = leftBound; i < nums.Length; i++)
                    {
                        rightMax = rightMax > nums[i] ? rightMax : nums[i];
                    }
                }
            
        }
    }
}