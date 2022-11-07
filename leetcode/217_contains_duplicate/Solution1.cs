using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._217_contains_duplicate
{
    public class Solution1
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers.Contains(nums[i]))
                {
                    return true;
                }
                numbers.Add(nums[i]);
            }
            return false;
        }
    }
}
