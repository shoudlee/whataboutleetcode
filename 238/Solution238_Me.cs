namespace Solution;

public class Solution238_Me
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] results = new int[nums.Length];
        int tempSuffixProduct = 1;
        results[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            results[i] = results[i - 1] * nums[i  - 1];
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            results[i] *= tempSuffixProduct;
            tempSuffixProduct *= nums[i];
        }

        return results;
    }
}