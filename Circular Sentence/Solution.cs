using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Sentence
{
    public class Solution
    {
        public bool IsCircularSentence(string s)
        {
            for (int i = 0; i < s.Length-1; i++) {
                if (s[i + 1] == ' ' && s[i + 2] != s[i])
                    return false;
            }
            return s[s.Length - 1] == s[0];
        }
    }
}
