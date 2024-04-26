namespace Solution;

// 超出时间了我艹
public class Solution134_Me
{
    public static int CanCompleteCircuit(int[] gas, int[] cost)
    {
        for (int i = 0; i < gas.Length; i++)
        {
            int tank = 0;
            int currentStation = i;
            int nextStation = (i + 1) % gas.Length;
            bool[] isVisited = new bool[cost.Length];
            for (int j = 0; j < cost.Length; j++)
            {
                isVisited[i] = false;
            }

            // isVisited[i] = true;
            
            while (true)
            {
                if (!isVisited[nextStation])
                {
                    tank += gas[currentStation];
                    tank -= cost[currentStation];
                    if (tank < 0)
                    {
                        break;
                    }
                    isVisited[nextStation] = true;

                    currentStation = nextStation;
                    nextStation = (nextStation + 1) % isVisited.Length;
                }
                else
                {
                    return i;
                }
                
                
            }

        }

        return -1;
    }

    // public static void Main()
    // {
    //     Console.WriteLine(CanCompleteCircuit([1,2,3,4,5], [3,4,5,1,2]));
    // }
}