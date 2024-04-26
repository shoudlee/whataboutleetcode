using System.Reflection.Metadata.Ecma335;

namespace Solution
{
    public class Solution088
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int indexT = 0;
            int index1 = 0;
            int index2 = 0;
            var temp = new List<int>();

            if ( m == 0)
            {
                while (index2 < n)
                {
                    temp.Add(nums2[index2]);
                    index2++;
                    indexT++;
                }
            }

            if ( n == 0)
            {
                while (index1 < m)
                {
                    temp.Add(nums1[index1]);
                    index1++;
                    indexT++;
                }
            }
            
            while (indexT < m + n)
            {
                if (index1 == m)
                {
                    while (index2 < n)
                    {
                        temp.Add(nums2[index2]);
                        index2++;
                        indexT++;
                    }
                    break;
                }
                
                if (nums1[index1] <= nums2[index2])
                {
                    temp.Add(nums1[index1]);
                    index1++;
                }
                else
                {
                    temp.Add(nums2[index2]);
                    index2++;
                    if (index2 == n)
                    {
                        while (index1 < m)
                        {
                            temp.Add(nums1[index1]);
                            index1++;
                            indexT++;
                        }
                        break;
                    }
                }
                indexT++;
            }

            for (int i = 0; i < temp.Count; i++)
            {
                nums1[i] = temp[i];
            }
        }

        // public static void Main()
        // {
        //     int[] a = new[] { 1, 2, 2, 6, 7, 0 ,0 };
        //     int[] b = new[] { 4, 5 };
        //
        //     Merge(a, 5, b, 2);
        //     foreach (var VARIABLE in a)
        //     {
        //         Console.WriteLine(VARIABLE);
        //     }
        // }
    }
}