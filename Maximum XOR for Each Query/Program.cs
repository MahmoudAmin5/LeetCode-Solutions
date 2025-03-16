namespace Maximum_XOR_for_Each_Query
{
    public class Solution
    {
        public int[] GetMaximumXor(int[] nums, int maximumBit)
        {
            int[]result = new int[nums.Length];
            int mxbit = (1 << maximumBit) - 1;
            int xor = 0;
            for(int i = 0; i < nums.Length; i++)
                xor^=nums[i];
            int k = 0;
            for(int i = 0;i < nums.Length; i++)
            {
                k = xor ^ mxbit;
                result[i] = k;
                xor ^= nums[nums.Length - i-1];
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Solution solution = new Solution();
            int[] nums = [0, 1, 1, 3];
            int mx = 2;
            Console.WriteLine($"[{string.Join(", ",solution.GetMaximumXor(nums,mx))}]");
        }
    }
}
