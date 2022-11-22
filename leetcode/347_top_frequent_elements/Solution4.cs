using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._347_top_frequent_elements
{
    public class Solution4
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            if (k == 0 || nums.Length == 0)
            {
                return Array.Empty<int>();
            }

            var countNums = new Dictionary<int, int>();
            var kArray = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {
                countNums[nums[i]] = 1 + countNums.GetValueOrDefault(nums[i], 0);
            }

            for (int i = 0; i < k; i++)
            {
                var maxKeyValue = countNums.MaxBy(x => x.Value);
                kArray[i] = maxKeyValue.Key;
                countNums[maxKeyValue.Key] = default;
            }

            return kArray;
        }
    }
}
