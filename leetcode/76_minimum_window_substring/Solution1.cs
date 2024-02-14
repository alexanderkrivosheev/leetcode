using Microsoft.Diagnostics.Runtime.Utilities;
using System;

namespace leetcode._minimum_window_substring
{
    public class Solution1
    {
        public string MinWindow(string s, string t)
        {
            var positions = new Dictionary<char, List<int>>();
            var conditions = new Dictionary<char, int>();
            string minSubstring = string.Empty;
            int l = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (!conditions.ContainsKey(t[i]))
                {
                    conditions.Add(t[i], 1);
                    positions.Add(t[i], new List<int>());
                }
                else
                {
                    conditions[t[i]]++;
                }
            }

            for (int r = 0; r < s.Length; r++)
            {
                if (conditions.TryGetValue(s[r], out var quantity))
                {
                    if (positions[s[r]].Count == quantity)
                    {
                        positions[s[r]].Remove(positions[s[r]][0]);
                    }

                    positions[s[r]].Add(r);

                    bool isValid = true;
                    int minLeft = int.MaxValue;
                    foreach (var set in conditions)
                    {
                        isValid &= positions[set.Key].Count == set.Value;

                        if (isValid)
                        {
                            if (minLeft > positions[set.Key][0])
                            {
                                minLeft = positions[set.Key][0];
                            }
                        }
                    }

                    if (isValid)
                    {
                        l = minLeft;

                        int lenght = r + 1 - l;

                        if (string.IsNullOrEmpty(minSubstring) || minSubstring.Length > lenght)
                        {
                            minSubstring = s.Substring(l, lenght);
                        }
                    }
                }

            }

            return minSubstring;
        }
    }
}
