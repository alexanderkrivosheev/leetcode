using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._167_two_sum_array_sorted
{
    public class Solution1
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int index1 = 0;
            int index2 = numbers.Length - 1;
            int sum = 0;
            do
            {
                sum = numbers[index1] + numbers[index2];
                if (sum > target)
                {
                    index2--;
                }
                if (sum < target)
                {
                    index1++;
                }
            }
            while (sum != target);

            return new int[] { index1 + 1, index2 + 1 };
        }
    }
}
