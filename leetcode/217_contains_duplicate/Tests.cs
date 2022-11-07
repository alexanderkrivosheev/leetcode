using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._217_contains_duplicate
{
    public static class Tests
    {
        [Theory]
        
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 1 }, true)]
     
        public static void Solution_Case_1(int[] numbers, bool expected)
        {
            Solution1 solution = new Solution1();

            var result = solution.ContainsDuplicate(numbers);

            Assert.Equal(expected, result );
        }

        [Theory]

        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 3, 4, 1 }, true)]
        public static void Solution_2_Case_1(int[] numbers, bool expected)
        {
            Solution2 solution = new Solution2();

            var result = solution.ContainsDuplicate(numbers);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 3, 4, 1 }, true)]
        public static void Solution_3_Case_1(int[] numbers, bool expected)
        {
            Solution3 solution = new Solution3();

            var result = solution.ContainsDuplicate(numbers);

            Assert.Equal(expected, result);
        }
    }
}
  