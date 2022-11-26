using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._238_product_of_array_except_self
{
    public class Solution1
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] products = new int[nums.Length];
            int[] reverseProducts = new int[nums.Length];

            products[0] = nums[0];
            reverseProducts[nums.Length - 1] = nums[nums.Length - 1];

            for (int i = 1, j = nums.Length - 2; i < nums.Length; i++, j--)
            {
                products[i] = nums[i] * products[i - 1];
                reverseProducts[j] = nums[j] * reverseProducts[j + 1];                
            }

            int[] result = new int[nums.Length];
            result[0] = reverseProducts[1];
            result[nums.Length - 1] = products[nums.Length - 2];

            for (int i = 1; i < nums.Length - 1; i++)
            {
                result[i] = products[i - 1] * reverseProducts[i + 1];
            }

            return result;
        }
    }
}
