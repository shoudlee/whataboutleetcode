namespace Solution;

public class Solution134_Mee
{
    public static int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int[] total = new int[gas.Length];
        int total1 = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            total[i] = gas[i] - cost[i];
            total1 += total[i];
            // Console.WriteLine(total[i]);
        }
        if (total1 < 0)
        {
            return -1;
        }

        //双指针
        int front = 0;
        int rear = 0;
        int tank = 0;
        for (; front < gas.Length; )
        {
            
            while (tank >= 0)
            {
                tank += total[rear];
                rear = (rear + 1) % gas.Length;
                if (tank < 0)
                {
                    break;
                }

                // 退出
                if (rear == front)
                {
                    return front;
                }
            }

            while (tank < 0)
            {
                tank -= total[front];
                front++;
                if (front >= gas.Length)
                {
                    break;
                }
            }

           
        }

        
        return -1;
    }
    //
    // public static void Main(string[] args)
    // {
    //     Console.WriteLine(CanCompleteCircuit([2,3,4], [3,4,3]));
    // }
}