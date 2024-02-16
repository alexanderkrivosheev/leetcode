using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._find_minimum_array
{    
    public class Solution1
    {
        public int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length-1;

            int middle = 0;
            //{3, 4, 5, 1, 2} 
            while (right - left > 1)
            {
                middle = left + (right - left) / 2;

                if (nums[left] > nums[middle])
                {
                    right = middle;
                }
                else if (nums[middle] > nums[right])
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }
            }

            return nums[left] < nums[right]? nums[left]: nums[right];
        }
    }
}
