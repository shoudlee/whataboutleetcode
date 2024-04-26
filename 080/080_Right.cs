namespace Solution{

public class Solution080_Right {
    public static bool CanJump(int[] nums)
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
    
    // public static void Main()
    // {
    //     int[] _list = [3, 2, 1, 1, 4];
    //
    //     bool _b = CanJump(_list);
    //     
    //     Console.Write(_b);
    // }
}


}