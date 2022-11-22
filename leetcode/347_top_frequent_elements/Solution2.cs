using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._347_top_frequent_elements
{
    public class Solution2
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            int[] result = new int[k];
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]]++;
                else
                    dic.Add(nums[i], 1);
            }

            return dic.OrderByDescending(x => x.Value).Select(y => y.Key).Take(k).ToArray();
        }
    }
}
