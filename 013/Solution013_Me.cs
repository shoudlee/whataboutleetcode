namespace Solution;

public class Solution013_Me
{
    public static int Translate(char c)
    {
        switch (c)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
        }

        return -1;
    }
    public static int RomanToInt(string s)
    {
        int t = 0;
        for (int i = 0; i < s.Length-1; i++)
        {
            int a = Translate(s[i]);
            int b = Translate(s[i + 1]);
            if (a >= b)
            {
                t += a;
            }
            else
            {
                t -= a;
            }
        }

        t += Translate(s[s.Length - 1]);
        return t;
    }

    // public static void Main(string[] args)
    // {
    //     Console.WriteLine(RomanToInt("MCDLXXVI"));
    // }
}