using BenchmarkDotNet.Toolchains.InProcess.Emit.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._128_longest_consecutive_sequence
{
    public class Solution2
    {
       public int LongestConsecutive(int[] nums)
        {
            HashSet<int> table = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                table.Add(nums[i]);
            }


            int sequence = 0;
            int max = 0;
            int length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                length = 0;
                sequence = nums[i];

                if (table.Contains(sequence - 1))
                {
                    continue;
                }

                do
                {
                    length++;
                    sequence++;
                }
                while (table.Contains(sequence));

                if (max < length)
                {
                    max = length;
                }
            }

            return max;
        }
    }
}
