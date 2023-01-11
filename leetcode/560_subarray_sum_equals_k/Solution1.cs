using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._560_subarray_sum_equals_k
{    
    public class Solution1
    {
        public int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];

                    if (sum == k)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
