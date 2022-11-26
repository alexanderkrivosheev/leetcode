using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.even_numbers
{
    public class Solution1
    {
        public long TotalAllEvenNumbers(int[] nums)
        {
            return nums.Where(i => i % 2 == 0).Sum(i => (long)i) ;
        }
    }
}
