namespace Solution;
public class Solution_Me
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }

        string prefix = strs[0];
        foreach (var str in strs)
        {
            for (int i = 0; i < prefix.Length; i++)
            {
                if (i == str.Length)
                {
                    prefix = prefix.Substring(0, i);
                    continue;
                }
                
                if (str[i] == prefix[i])
                {
                    continue;
                }
                else
                {
                    if (i == 0)
                    {
                        return "";
                    }
                    else
                    {
                        prefix = prefix.Substring(0,i);
                    }
                }
            }
        }

        return prefix;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(LongestCommonPrefix( ["ab","a"]));
    }
}