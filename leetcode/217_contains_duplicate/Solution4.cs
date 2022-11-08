using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._217_contains_duplicate
{
    public class Solution4
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var arrayWithUniqueNumbers = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (arrayWithUniqueNumbers.TryAdd(item, item))
                {
                    continue;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
