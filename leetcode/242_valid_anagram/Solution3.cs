using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._242_valid_anagram
{
    public class Solution3
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var Smap = new Dictionary<char, int>();
            var Tmap = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                Smap[s[i]] = 1 + Smap.GetValueOrDefault(s[i], 0);
                Tmap[t[i]] = 1 + Tmap.GetValueOrDefault(t[i], 0);
            }

            foreach (var item in Smap)
            {
                if (Smap[item.Key] != Tmap.GetValueOrDefault(item.Key, 0))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
