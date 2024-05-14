using System.Reflection.Metadata.Ecma335;

namespace Solution;


public class Solution058_Me
{
    // public static void Main(string[] args)
    // {
    //     Console.WriteLine(LengthOfLastWord("Todaay is a nice day"));
    // }

    public static int LengthOfLastWord(string s)
    {
        int rightIndex;
        int count = 0;
        bool whiteSpaceAtEnd = true;
        for (rightIndex = s.Length - 1; rightIndex >= 0; rightIndex--)
        {
            if (s[rightIndex] != ' ')
            {
                count++;
                continue;
                whiteSpaceAtEnd = false;
            }

            if (whiteSpaceAtEnd)
            {
                continue;
            }
            
            if (s[rightIndex] == ' ' || rightIndex == 0)
            {
                break;
            }
        }

        return count;
    }
}

