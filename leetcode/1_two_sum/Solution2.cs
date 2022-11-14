using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._1_two_sum
{
    public class Solution2
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Count() < 2)
            {
                return Array.Empty<int>();
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i == j)
                    {
                        continue;
                    }

                    int result = nums[i] + nums[j];

                    if (result == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return Array.Empty<int>();
        }
    }
}
