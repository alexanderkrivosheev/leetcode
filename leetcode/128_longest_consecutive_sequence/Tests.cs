using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._128_longest_consecutive_sequence
{
    public static class Tests
    {
        [Theory]

        [InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 10000)]
        
        public static void Solution_Case_1(int[] nums, int expected)
         {
            Solution1 solution = new Solution1();
            int result = solution.LongestConsecutive(nums);
            Assert.Equal(expected, result);                    
        }      
    }
}
  