using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.nums_and_ranges
{
    public class Solution1
    {
        public string FindRanges(int[] nums)
        {
            HashSet<int> table = new HashSet<int>();

            foreach (var item in nums)
            {
                if (!table.Contains(item))
                {
                    table.Add(item);
                }
            }

            List<string> result = new List<string>();

            int startSequence = 0;
            int endSequence = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (table.Contains(nums[i] - 1))
                {
                    continue;
                }

                startSequence = nums[i];
                endSequence = nums[i];
                do
                {
                    if (table.Contains(endSequence + 1))
                    {
                        endSequence++;
                    }
                    else { break; }
                }
                while (true);

                if(startSequence == endSequence)
                {
                    result.Add($"{startSequence}");
                }
                else
                {
                    result.Add($"{startSequence}-{endSequence}");
                }
            }

            return string.Join(",", result);        }
    }
}
