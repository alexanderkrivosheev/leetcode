using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._238_product_of_array_except_self
{
    public class Solution2
    {
        public int[] ProductExceptSelf(int[] nums)
        {

            int[] result = new int[nums.Length];
            result[0] = 1;
            result[nums.Length - 1] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            for (int j = result.Length - 2; j >= 0; j--)
            {
                result[j] = result[j] * nums[j + 1];
                nums[j] = nums[j] * nums[j + 1];
            }

            return result;
        }
    }
}
