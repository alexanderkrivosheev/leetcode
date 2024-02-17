using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._search_rotated_array
{
    public static class Tests
    {
        [Theory]

        //[InlineData(new int[] { 11, 13, 15, 17 }, 11)]

        //[InlineData(new int[] { 3, 4, 5, 1, 2 }, 1)]
        [InlineData(new int[] { 5, 1, 3 }, 5, 0)]

        //[InlineData(new int[] { 17, 15, 13, 11 }, 11)]
        public static void Solution_Case_1(int[] s, int target, int expected)
        {
            var solution = new Solution1();
            var result = solution.Search(s, target);
            Assert.Equal(expected, result);
        }

    }
}
  