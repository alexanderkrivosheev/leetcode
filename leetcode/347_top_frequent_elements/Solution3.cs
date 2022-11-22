using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._347_top_frequent_elements
{
    public class Solution3
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            int n = nums.Length;
            Dictionary<int, int> map = new Dictionary<int, int>();
            IList<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], 1);
                else
                    map[nums[i]]++;
            }
            var sortedDict = from entry in map orderby entry.Value descending select entry;
            foreach (var item in sortedDict)
            {
                result.Add(item.Key);
                k--;
                if (k == 0)
                    break;
            }
            return result.ToArray();
        }
    }
}
