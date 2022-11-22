using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._347_top_frequent_elements
{
    public static class Tests
    {
        [Theory]
        [InlineData(new int[] { 5, 3, 1, 1, 1, 3, 73, 1 }, 1, new int[] { 1 })]        
        public static void Solution_Case_1(int[]nums, int k, int[] expected)
        {
            Solution1 solution1 = new Solution1();
            var result = solution1.TopKFrequent(nums, k);
            result.Should().Equal(expected);
        }      
    }
}
  