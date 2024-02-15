using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._valid_parentheses
{
    public class Solution2
   {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int longestSubstring = 0;
            int leftWing = 0;

            for (int r = 0; r <s.Length; r++)
            {
                while (set.Contains(s[r]))
                {
                    set.Remove(s[leftWing]);
                    leftWing++;
                }

                set.Add(s[r]);     

                if(longestSubstring < set.Count)
                {
                    longestSubstring = set.Count;
                }
            }
 
            return longestSubstring;
        }
    }
}