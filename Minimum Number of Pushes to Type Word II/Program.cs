namespace Minimum_Number_of_Pushes_to_Type_Word_II
{
    public class Solution
    {
        public int MinimumPushes(string word)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in word)
            {
                dict[item] = dict.GetValueOrDefault(item, 0) + 1;
            }
            var list = dict.Values.OrderByDescending(x => x).ToList();
            int ans = 0;
            for (int i = 0; i < list.Count; i++)
            {
                ans += list[i] * ((i == 0) ? ((i + 7 + 1) / 8) : (((i + 8) / 8)));
            }
            return ans;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
