namespace Problems;

public class LC152
{
    public int MaxProduct(int[] nums)
    {
        int maxProduct = nums[0];
        int minProduct = nums[0];
        int result = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            int n = nums[i];

            int a = n;
            int b = n * maxProduct;
            int c = n * minProduct;

            maxProduct = Math.Max(a, Math.Max(b, c));
            minProduct = Math.Min(a, Math.Min(b, c));

            result = Math.Max(result, maxProduct);
        }

        return result;
    }
}