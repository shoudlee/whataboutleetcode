using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace Solution{

// out of memory!
class Solution04_Me{
    public static int Trap(int[] height) {
        int maxHeight = 0;
        for(int i = 0; i< height.Length; i++)
        {
            maxHeight = maxHeight > height[i] ? maxHeight: height[i];
        }
        if(maxHeight == 0){return 0;}

        int[,] waterModel = new int[maxHeight, height.Length];
        for(int i = 0;i < maxHeight;i++)
        {
            for (int j = 0; j < height.Length; j++)
            {
                if(height[j] > i ){
                    waterModel[i,j] = 1;
                }else{
                    waterModel[i,j] = 0;
                }
            }
        }

        // 有砖块是1,半水是9,有水是2
        int water = 0;
        for (int i = 0; i < maxHeight; i++)
        {
            for (int j = 1; j < height.Length -1; j++)
            {
                if(i==0)
                {
                    if(waterModel[i,j]==0)
                    {
                        if (waterModel[i, j-1] == 1 || waterModel[i, j-1] == 9)
                        {
                            waterModel[i,j]= 9;
                        }

                    }
                }
                
                if(i > 0)
                {
                    if(waterModel[i,j]==0){
                        if ((waterModel[i, j-1] == 1 || waterModel[i, j-1] == 9) && (waterModel[i -1, j] == 1 || waterModel[i-1,j]==2))
                        {
                            waterModel[i,j]= 9;
                        }
                   }


            }
            }

            for (int j = height.Length -2; j > 0; j--)
            {
                if (waterModel[i,j] == 9)
                {
                    if(waterModel[i,j+1] == 1 || waterModel[i,j+1] == 2){
                        waterModel[i,j] = 2;
                        water++;
                    }else{
                        waterModel[i,j] = 0;
                    }
                }
                
            }

        }

        return water;
    }

    // public static void Main(){
    //     Console.WriteLine(Trap([4,2,0,3,2,5]));
    // }

}

}