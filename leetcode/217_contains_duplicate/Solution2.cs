using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._217_contains_duplicate
{
    public class Solution2
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.GroupBy(x => x).Any(x => x.Count() > 1);
        }
    }
}
