using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._217_contains_duplicate
{
    public static class Solution1Tests
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
    }
}
  