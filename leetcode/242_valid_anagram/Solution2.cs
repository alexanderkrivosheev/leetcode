using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._242_valid_anagram
{
    public class Solution2
    {
        public bool IsAnagram(string s, string t)
        {            
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] arra1 = s.ToCharArray();
            char[] arra2 = t.ToCharArray();

            Array.Sort(arra1);
            Array.Sort(arra2);

            for (int i = 0; i < s.Length; i++)
            {
                if (arra1[i] != arra2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
