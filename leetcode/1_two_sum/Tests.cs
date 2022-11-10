using FluentAssertions;
using leetcode._217_contains_duplicate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._1_two_sum
{
    public static class Tests
    {
        [Theory]        
        [InlineData(new int[] { 1, 1, 1, 1 }, 2,new int[] {1,0})]
        [InlineData(new int[] { 1, 2, 3, 4 }, 6, new int[] { 3, 1 })]
        public static void Solution_Case_1(int[] numbers, int target, int[] expected)
        {
            Solution1 solution = new Solution1();

            var result = solution.TwoSum(numbers,target);

            result.Should().Equal(expected);
        }      
    }
}
  