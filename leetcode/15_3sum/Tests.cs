using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._15_3sum
{
    public static class Tests
    {
        [Theory]

        [InlineData(new int[] { -1, 0, 1, 2, -1, -4 })]        
        public static void Solution_Case_1(int[] numbers)
        {
            Solution1 solution = new Solution1();

            var result = solution.ThreeSum(numbers);
        }
    }
}
  