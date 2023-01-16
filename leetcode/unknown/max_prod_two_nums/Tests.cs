using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.max_prod_two_nums
{
    public static class Tests
    {
        [Theory]
        //[InlineData(new int[] { 1, 3, 2, 9 }, 27)]
        [InlineData(new int[] { 3, 2, 12, 12, -7 }, 36)]
        public static void Solution_Case_1(int[] numbers, int target)
        {
            Solution1 solution = new Solution1();

            var result = solution.Calclulate(numbers);
            result.Should().Equals(target);
        }
    }
}
  