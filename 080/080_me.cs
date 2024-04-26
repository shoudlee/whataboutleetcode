namespace Solution;


using System.Data;
using System.Reflection;

// 一遍过，帅！
public class Solution080 {
    public static int RemoveDuplicates(int[] nums)
    {
        int index1 = 0;
        int index2 = 0;
        int index3 = 0;
        int numsRear = nums.Length - 1;
        int t;
        
        
        

        for (; index1 != numsRear; index1++)
        {
            // 1
            // 重复检查，如果nums[0,index1)中已经有index1之值，说明已经删重过index1之值
            for (t = 0; t < index1; t++)
            {
                if (nums[index1] == nums[t])
                {
                    break;
                }
            }
            // 如果重复直接去下次循环
            if (t != index1 && nums[t] == nums[index1])
            {
                continue;
            }
            
            
            //  2
            // 移动index2去找第二个重复值
            for (index2 = index1 + 1;  index2 <= numsRear; index2++)
            {
                // 找到重复者
                if (nums[index2] == nums[index1])
                {
                    break;
                }
            }
            // 第一种情况index2未找到重复值或index2找到重复值但处于末尾，此二者不需要出动index3
            if (index2 > numsRear)
            {
                continue;
            }
            
            //  3
            // 第二种情况，index2固定在了numsRear之前，请出动index3吧将军！
            for (index3 = index2 + 1; index3 <= numsRear; index3++)
            {
                // 找到相同者，杀！(index3, numsRear]左移1, numsRear+1, index3--
                if (nums[index3] == nums[index2])
                {
                    for (int i = index3; i < numsRear; i++)
                    {
                        nums[i] = nums[i + 1];
                    }

                    index3--;
                    numsRear--;
                }
            }
            
        }

        
        
        return index1 + 1;
    }

    // public static void Main()
    // {
    //     int[] ints = [1,2,2,2,2,2,2,2,3,3,3,4];
    //     
    //     foreach (var t in ints)
    //     {
    //         Console.Write(t+" ");
    //     }
    //     
    //     Console.WriteLine(RemoveDuplicates(ints));
    //     
    //     Console.WriteLine();
    //     foreach (var t in ints)
    //     {
    //         Console.Write(t+ " ");
    //     }
    //     
    // }
    
}