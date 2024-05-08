using System.Diagnostics;
using System.Runtime.Serialization.Formatters;

namespace Solution{

    public class Solution042_Right{
        public static int Trap(int[] height) {
            int water =0;
            int[] leftMax = new int[height.Length];
            int[] rightMax = new int[height.Length];

            int max = 0;
            for (int i = 0; i < height.Length; i++)
            {
                max = max > height[i] ? max:height[i];
                leftMax[i] = max;
            }
            max = 0;
            for(int i = height.Length -1 ; i > -1;i--)
            {
                max = max > height[i] ? max:height[i];
                rightMax[i] = max;
            }

            for (int i = 1; i < height.Length-1; i++)
            {
                int count =  Math.Min(leftMax[i], rightMax[i]) - height[i];
                if(count <0){
                    water+=0;
                }else{
                    water += count;
                }
            }

            
            
            return water;
        }




        // public static void Main(){
        //     // Trap([0,1,0,2,1,0,1,3,2,1,2,1]);
        //     Console.WriteLine(Trap([0,1,0,2,1,0,1,3,2,1,2,1]));
        // }
    }
  



}