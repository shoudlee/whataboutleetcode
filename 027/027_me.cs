namespace Solution;


public class Solution027 {
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int counter = 0;
        {
            
        }
        if (nums.Length == 1)
        {
            return nums[0] == val ? 0 : 1;
        }
        
        int indexH = 0;
        int indexR = nums.Length - 1;
        
        for (;true;)
        {
            
            for ( ; indexH < indexR; indexH++)
            {
                if (nums[indexH] == val)
                {
                    break;
                }

                counter++;
            }

            if (indexH == indexR)
            {
                if (nums[indexH] == val)
                {
                    return counter;
                }
                else
                {
                    return ++counter;
                }
            }

            for (; indexR > indexH; indexR--)
            {
                if (nums[indexR] != val)
                {
                    nums[indexH] = nums[indexR];
                    nums[indexR] = val;
                    break;
                }
            }
        }
        


    }
}