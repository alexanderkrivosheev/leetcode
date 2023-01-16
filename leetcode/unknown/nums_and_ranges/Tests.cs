using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.nums_and_ranges
{
    public static class Tests
    {
        [Theory]
        [InlineData(new int[] { 4, 5, 6, 7, 1, 9, 15, 16, 17 })]
        public static void Solution_Case_1(int[] numbers)
        {
            Solution1 solution = new Solution1();

            var result = solution.FindRanges(numbers);         
        }
    }
}
  