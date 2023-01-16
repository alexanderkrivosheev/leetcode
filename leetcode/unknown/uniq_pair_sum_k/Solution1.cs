using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.uniq_pair_sum_k
{
    public class Solution1
    {
        //6
        //1,2,3,0,6,2,7,5,6
        //

        public int Calclulate(int[] nums, int target)
        {
            int count = 0;

            Dictionary<int, bool> table = new Dictionary<int, bool>();
           
            for (int i = 0; i < nums.Length; i++)
            {
                if (!table.ContainsKey(nums[i]))
                {
                    table.Add(nums[i], false);
                }
                else if (table[nums[i]])
                {
                    continue;
                }

                int targetValue = target - nums[i];

                if (table.ContainsKey(targetValue))
                {
                    count++;
                    table[targetValue] = true;
                    table[nums[i]] = true;
                }
            }

            return count;
        }
    }
}
