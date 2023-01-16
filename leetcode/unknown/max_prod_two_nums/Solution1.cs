using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.max_prod_two_nums
{
    public class Solution1
    {
        public int Calclulate(int[] nums)
        {
            int firstMax = 0;
            int secondMax = 0;
            for(int i= 0; i<nums.Length; i++)
            {
                if (firstMax < nums[i])
                {
                    secondMax = firstMax;
                    firstMax = nums[i];
                } 
                else if(secondMax < nums[i])
                {
                    secondMax = nums[i];
                }                
            }

            return firstMax*secondMax;
        }
    }
}
