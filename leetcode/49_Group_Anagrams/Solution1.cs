using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._49_Group_Anagrams
{
    public class Solution1
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<char, int>[] detailsOfAnogram = new Dictionary<char, int>[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                detailsOfAnogram[i] = new Dictionary<char, int>();
                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (detailsOfAnogram[i].ContainsKey(strs[i][j]))
                    {
                        detailsOfAnogram[i][strs[i][j]] += 1;
                    }
                    else
                    {
                        detailsOfAnogram[i].Add(strs[i][j], 1);
                    }
                }
            }

            List<List<string>> groupedAnagrams = new List<List<string>>();
            List<string> mappedAnagrams;

            for (int i = 0; i < detailsOfAnogram.Length; i++)
            {
                if (detailsOfAnogram[i] == null)
                {
                    continue;
                }

                mappedAnagrams = new List<string>();
                mappedAnagrams.Add(strs[i]);

                for (int j = i + 1; j < detailsOfAnogram.Length; j++)
                {
                    if (detailsOfAnogram[j] == null || detailsOfAnogram[i].Count != detailsOfAnogram[j].Count)
                    {
                        continue;
                    }

                    bool isAnagram = true;

                    foreach (var item in detailsOfAnogram[i])
                    {
                        if (!detailsOfAnogram[j].ContainsKey(item.Key) || detailsOfAnogram[j][item.Key] != item.Value)
                        {
                            isAnagram = false;
                            break;
                        }
                    }

                    if (isAnagram)
                    {
                        detailsOfAnogram[j] = null;
                        mappedAnagrams.Add(strs[j]);
                    }
                }

                groupedAnagrams.Add(mappedAnagrams);
            }

            return groupedAnagrams.ToArray();
        }
    }
}
