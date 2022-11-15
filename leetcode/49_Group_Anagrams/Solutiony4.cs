using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._49_Group_Anagrams
{
    public class Solution4
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                string key = GetKey(str);
                List<string> group;
                if (!groupedAnagrams.TryGetValue(key, out group))
                {
                    group = new List<string>();
                    groupedAnagrams.Add(key, group);
                }

                group.Add(str);
            }

            return new List<IList<string>>(groupedAnagrams.Values);
        }

        private string GetKey(string word)
        {
            int[] vector = new int[26];
            foreach (var s in word)
            {
                vector[s - 'a'] += 1;
            }

            StringBuilder builder = new StringBuilder();
            foreach (var item in vector)
            {
                builder.Append(item);
            }

            return builder.ToString();
        }
    }
}
