using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._49_Group_Anagrams
{
    public class Solution3
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);
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
    }
}
