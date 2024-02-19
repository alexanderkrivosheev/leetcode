using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._242_valid_anagram
{
    public class Solution4    
    {
        public bool IsAnagram(string s, string t)
        {
            var set = new Dictionary<char, int>();

            for (int i = 0; i < t.Length; i++)
            {
                if (set.ContainsKey(t[i]))
                {
                    set[t[i]]++;
                }
                else
                {
                    set.Add(t[i], 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (set.ContainsKey(s[i]))
                {
                    set[s[i]]--;
                    if (set[s[i]] == 0)
                    {
                        set.Remove(s[i]);
                    }
                }
                else
                {
                    return false;
                }
            }

            return set.Count == 0;
        }
    }
}
