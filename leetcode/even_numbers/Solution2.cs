using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.even_numbers
{
    public class Solution2
    {
        static long TotalAllEvenNumbers(int[] intArray)
        {
            return (from i in intArray where i % 2 == 0 select (long)i).Sum();
        }
    }
}
