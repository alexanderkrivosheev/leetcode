using BenchmarkDotNet.Toolchains.InProcess.Emit.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._128_longest_consecutive_sequence
{
    public class Solution1
    {
        private string GetSequence(Dictionary<string, string> table, string key)
        {
            string result;
            if (table.TryGetValue(key, out result))
            {
                if (key == result)
                {
                    return result;
                }

                return GetSequence(table, result) ?? result;
            }

            return result;
        }

        private int ExtractValue(string raw, int index)
        {            
            if (!string.IsNullOrEmpty(raw))
            {
                var sequence = raw.Split(',');
                if (sequence.Length == 2)
                {
                    int value;
                    if(int.TryParse(sequence[index], out value))
                    {
                        return value;
                    };
                }
            }

            return 0;
        }

        public int LongestConsecutive(int[] nums)
        {
            Dictionary<string, string> table = new Dictionary<string, string>();

            var maxLength = 0;

            for (int i = 0; i < nums.Length; i++)
             {
                var currentValue = $"{nums[i]}";
                 var leftValue = $"{nums[i] - 1}";
                var rightValue = $"{nums[i] + 1}";

                if (table.ContainsKey(currentValue))
                {
                    continue;
                }

                var leftSequence = GetSequence(table, leftValue);
                var rightSequence = GetSequence (table, rightValue);

                int startSequence = nums[i];
                int endSequence = nums[i];

                if (!string.IsNullOrEmpty(leftSequence))
                {
                    startSequence = ExtractValue(leftSequence, 0);
                }

                if (!string.IsNullOrEmpty(rightSequence))
                {
                    endSequence = ExtractValue(rightSequence, 1);
                }

                var newSequence = $"{startSequence},{endSequence}";
                
                var length = endSequence - startSequence+1;
                if(length > maxLength)
                {
                    maxLength = length;
                }

                if (!string.IsNullOrEmpty(leftSequence))
                {
                    table[leftSequence] = newSequence;
                }

                if (!string.IsNullOrEmpty(rightSequence))
                {
                    table[rightSequence] = newSequence;
                }

                table[currentValue] = newSequence; 

            }

            return maxLength;
        }
    }
}
