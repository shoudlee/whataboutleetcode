namespace Solution;

public class Solution274_me
{
    public static int HIndex(int[] citations)
    {
        List<int> citationsList = new List<int>(citations);
        citationsList.Sort();
        int hMax = Math.Min(citationsList.Count, citationsList[citationsList.Count - 1]);
        while (true)
        {
            int count = 0;
            for (int i = citationsList.Count - 1; i >= 0; i--)
            {
                if (citationsList[i] >= hMax)
                {
                    count++;
                    if (count >= hMax)
                    {
                        return hMax;
                    }
                }
                else
                {
                    if (count >= hMax)
                    {
                        return hMax;
                    }
                    else
                    {
                        break;
                    }
                }
                
            }

            hMax--;
            if (hMax <= 0)
            {
                return 0;
            }

        }
    }

    // public static void Main()
    // {
    //     int[] citations = [1,3,1];
    //     Console.WriteLine(HIndex(citations));
    // }
}