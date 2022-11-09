using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._242_valid_anagram
{
    public class Solution1
    {
        public bool IsAnagram(string s, string t)
        {            
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> table = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (table.ContainsKey(s[i]))
                {
                    table[s[i]] += 1;

                    if (table[s[i]] == 0)
                    {
                        table.Remove(s[i]);
                    }
                }
                else
                {
                    table.Add(s[i], 1);
                }

                if (table.ContainsKey(t[i]))
                {
                    table[t[i]] -= 1;

                    if (table[t[i]] == 0)
                    {
                        table.Remove(t[i]);
                    }
                }
                else
                {
                    table.Add(t[i], -1);
                }
            }

            return table.Count == 0;
        }
    }
}
