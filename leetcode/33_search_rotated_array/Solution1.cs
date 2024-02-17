using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._search_rotated_array
{    
    public class Solution1
    {
        public int Search(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length - 1;
            int middle = 0;
            //{ 4, 5, 6, 7, 0, 1, 2 }
            while (left <= right)
            {
                middle = left + (right - left) / 2;

                if (target == nums[middle])
                {
                    return middle;
                }

                //left section
                if (nums[middle] >= nums[left]) 
                {
                    if (target >= nums[left] && target <= nums[middle]) 
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                //right section
                if (nums[middle] <= nums[right])
                {
                    if (target >= nums[middle] && target <= nums[right])
                    {
                        left = middle+1;                        
                    }
                    else
                    {
                        right = middle;
                    }
                }              
            }

            return -1;
        }
    }
}
