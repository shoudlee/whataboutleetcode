using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Solution;
/*
定义一个字符串t，空串
判断是否大于1000，如果大于则判断几个1000，有几个加几个M，并扣除几个1000
判断是否大于900，是否CM并减
判断是否大于500，是否D并减
判断是否大于400，是否CD并减
判断是否大于100，有几个100则几个C并减
判断是否大于90，是否XC并减
判断是否大于50，是否L并减
判断是否大于10，有几个10则几个X并减
判断是否大于9，IX
判断是否大于5，IV
判断是否大于4，IV
判断几个I
 */
public class Solution012_Me
{
    public static string IntToRoman(int num)
    {
        String roman = "";
        if (num >= 1000)
        {
            int t = HowManyXInY(num, 1000);
            Console.WriteLine(t);
            for (int i = 0; i < t; i++)
            {
                roman+=('M');
            }

            num -= t * 1000;
        }

        if (num >= 900)
        {
            roman += "CM";
            num -= 900;
        }

        if (num >= 500)
        {
            roman += "D";
            num -= 500;
        }

        if (num >= 400)
        {
            roman += "CD";
            num -= 400;
        }

        if (num >= 100)
        {
            int t = HowManyXInY(num, 100);
            for (int i = 0; i < t; i++)
            {
                roman+=('C');
            }

            num -= t * 100;
        }

        if (num >= 90)
        {
            roman += "XC";
            num -= 90;
        }

        if (num >= 50)
        {
            roman += "L";
            num -= 50;
        }
        if (num >= 40)
        {
            roman += "XL";
            num -= 40;
        }
        if (num >= 10)
        {
            int t = HowManyXInY(num, 10);
            for (int i = 0; i < t; i++)
            {
                roman+=('X');
            }

            num -= 10 * t;
        }

        if (num >= 9)
        {
            roman += "IX";
            num -= 9;
        }

        if (num >= 5)
        {
            roman += "V";
            num -= 5;
            
        }

        if (num >= 4)
        {
            roman += "IV";
            num -= 4;
        }

        if (num >= 1)
        {
            int t = HowManyXInY(num, 1);
            for (int i = 0; i < t; i++)
            {
                roman+='I';
            }

            num -= t;
        }
        return roman;
    }

    public static int HowManyXInY(int y, int x)
    {
        int count = 0;
        for (int i = 0;;)
        {
            if ( i < y)
            {
                i += x;
                count++;
                continue;
            }

            if (i == y)
            {
                return count;
            }

            if (i > y)
            {
                return count - 1;
            }
        }
        
        return -1;
    }

    // public static void Main(string[] args)
    // {
    //     Console.WriteLine(HowManyXInY(3,1));
    //     // Console.WriteLine(IntToRoman(58));
    // }
}