using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._longest_substring
{    
    public class Solution1
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<Hashtable> substrings = new List<Hashtable>();
            int maxSubStringLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                Hashtable newSubstring = new Hashtable();
                newSubstring.Add(s[i], s[i]);

                substrings.Add(newSubstring);

                for (int j = 0; j < substrings.Count; j++)
                {
                    if (!substrings[j].Contains(s[i]))
                    {
                        substrings[j].Add(s[i], s[i]);
                    }
                    else
                    {
                        if (newSubstring != substrings[j])
                        {
                            substrings[j].Clear();
                        }
                    }

                    if (maxSubStringLength < substrings[j].Count)
                    {
                        maxSubStringLength = substrings[j].Count;
                    }
                }
            }

            return maxSubStringLength;
        }
    }
}
