
namespace Solution
{
    public class Solution
    {
        public class Solution169 {
            public int MajorityElement(int[] nums)
            {
                int majorNumber = nums[0];
                int times = 1;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] == majorNumber)
                    {
                        times++;
                    }
                    else
                    {
                        times--;
                        if (times == 0)
                        {
                            majorNumber = nums[i];
                            times = 1;
                        }
                    }
                }

                return majorNumber;
            }
        }
    }
}
