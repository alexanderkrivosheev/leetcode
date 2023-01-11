using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._560_subarray_sum_equals_k
{
    public class Solution2
   {
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> sums = new Dictionary<int, int>();
            sums.Add(0, 1);
            var prefSum = 0;
            var sum = 0;
            var count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                prefSum += nums[i];

                sum = prefSum - k;
                if (sums.ContainsKey(sum))
                {
                    count += sums[sum];
                }

                if (!sums.ContainsKey(prefSum))
                    sums.Add(prefSum, 1);
                else
                    sums[prefSum]++;
            }

            return count;
        }
    }
}
