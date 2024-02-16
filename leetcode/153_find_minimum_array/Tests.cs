using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._find_minimum_array
{
    public static class Tests
    {
        [Theory]

        //[InlineData(new int[] { 11, 13, 15, 17 }, 11)]

        //[InlineData(new int[] { 3, 4, 5, 1, 2 }, 1)]
        //[InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0)]

        [InlineData(new int[] { 17, 15, 13, 11 }, 11)]
        public static void Solution_Case_1(int[] s,int expeted)
        {
            Solution2 solution = new Solution2();
            var result = solution.FindMin(s);
            Assert.Equal(expeted, result);
        }

    }
}
  