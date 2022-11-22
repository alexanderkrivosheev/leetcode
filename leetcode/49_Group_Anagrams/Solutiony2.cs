using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._49_Group_Anagrams
{
    public class Solution2
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();
            char[] chars;
            string key;            
            for (int i = 0; i < strs.Length; i++)
            {
                chars = strs[i].ToCharArray();
                Array.Sort(chars);
                key = new string(chars);
                List<string> group;
                if (!groupedAnagrams.TryGetValue(key, out group))
                {
                    group = new List<string>();
                    groupedAnagrams.Add(key, group);
                }

                group.Add(strs[i]);
            }

            return new List<IList<string>>(groupedAnagrams.Values);
        }
    }
}
