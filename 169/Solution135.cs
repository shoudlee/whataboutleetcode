namespace Solution;

public class Solution135
{
    public static int Candy(int[] ratings) {
        if (ratings.Length == 1)
        {
            return 1;
        }

        int[] candys = new int[ratings.Length];
        
        for (int i = 0; i < ratings.Length; i++)
        {
            candys[i] = 1;
        }
        
        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i-1])
            {
                candys[i] = candys[i - 1] + 1;
            }
        }

        int total = 0;
        for (int i = ratings.Length -2; i > -1; i--)
        {
            total += candys[i + 1];
            if (ratings[i] > ratings[ i + 1])
            {
                if (candys[i] <= candys[i+1])
                {
                    candys[i] = candys[i + 1] + 1;
                }
            }
        }

        total += candys[0];
        return total;
    }

    // public static void Main(string[] args)
    // {
    //     Console.WriteLine(Candy([1,2,2]));
    // }
}