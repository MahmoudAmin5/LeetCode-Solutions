namespace Find_Champion_II
{
    public class Solution
    {
        public int FindChampion(int n, int[][] edges)
        {
            int[] freq = new int[n];
            int count = 0 , ans=-1;

            for (int i = 0; i < edges.Length; i++) {
                freq[edges[i][1]]++;
            }
            for (int i = 0; i < n; i++) { 
               if(freq[i] == 0)
                {
                    count++;
                    ans = i;
                }
            }
            return (count == 1) ? ans : -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    }

