using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._1_two_sum
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();
            int summand;
            for (int i = 0; i < nums.Length; i++)
            {
                summand = target - nums[i];
                if (table.ContainsKey(summand))
                {
                    return new int[] { i, table[summand] };
                }
                else if (!table.ContainsKey(nums[i]))
                {
                    table.Add(nums[i], i);
                }
            }

            return new int[0];
        }
    }
}
