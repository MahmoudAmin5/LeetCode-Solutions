namespace Make_Two_Arrays_Equal_by_Reversing_Subarrays
{
    public class Solution
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            Dictionary<int,int>dict = new Dictionary<int,int>();
            Dictionary<int, int> dictArr = new Dictionary<int, int>();
            foreach (int i in target) {
                dict[i] = dict.GetValueOrDefault(i, 0) + 1;
            }
            foreach (int i in arr)
            {
                dictArr[i] = dictArr.GetValueOrDefault(i, 0) + 1;
            }
            foreach(var i in dict)
            {
                if (dictArr.ContainsKey(i.Key))
                    if (i.Value == dictArr[i.Key])
                        continue;
                return false;
            }
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int [] arr = { 1, 2, 3 };
            int[] arr2 = { 3, 1, 2 };
            Console.WriteLine($"{solution.CanBeEqual(arr,arr2)}");
        }
    }
}
