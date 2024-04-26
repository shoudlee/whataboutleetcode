namespace Solution;
public class Solution045
{
    public static int Jump(int[] nums)
    {

        if (nums.Length == 1)
        {
            return 0;

        }
        
        int leftBound = 1;
        int rightBound = nums[0];
        int reach;
        int count = 1;

        while (rightBound < nums.Length - 1)
        {
            reach = 0;
            for (int i = leftBound; i <= rightBound; i++)
            {
                if (i + nums[i] > reach)
                {
                    leftBound = i;
                    reach = i + nums[i];
                }
            }

            count++;
            rightBound = leftBound + nums[leftBound];
        }

        return count;
    }
    //
    // public static void Main()
    // {
    //     int[] nums = [1,2,3];
    //     Console.WriteLine(Jump(nums));
    // }
}