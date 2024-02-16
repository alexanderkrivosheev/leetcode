using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._find_minimum_array
{
    public class Solution2
   {
        public int FindMin(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                if (nums[left] <= nums[right])
                {
                    return nums[left];
                }
                int mid = (left + right) / 2;
                if (nums[mid] >= nums[left])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return 0;
        }
    }
}