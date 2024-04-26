namespace Solution;

public class Solution055_Right
{
    public static bool Jump(int[] nums)
    {
        int reach = nums[0];
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            if ( i > reach)
            {
                return false;
            }

            reach = Math.Max(reach, i + nums[i]);

        }
        
        return true;
    }
    }


