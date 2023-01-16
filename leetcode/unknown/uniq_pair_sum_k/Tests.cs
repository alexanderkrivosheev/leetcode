using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.uniq_pair_sum_k
{
    public static class Tests
    {
        [Theory]
        //[InlineData(new int[] { 1, 3, 2, 9 }, 27)]
        [InlineData(new int[] { 1, 2, 3, 0, 6, 2, 3, 2, 7, 5, 6 }, 6)]
        public static void Solution_Case_1(int[] numbers, int target)
        {
            Solution1 solution = new Solution1();

            var result = solution.Calclulate(numbers, 6);
            result.Should().Equals(target);
        }
    }
}
  