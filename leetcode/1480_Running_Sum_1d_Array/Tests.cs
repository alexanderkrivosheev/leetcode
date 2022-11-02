using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._1480_Running_Sum_1d_Array
{
    public static class Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [InlineData(new int[] { 1,1,1,1 }, new int[] { 1, 2, 3, 4 })]
        public static void RunningSum_Case_1(int[] numbers, int[] expected)
        {
            var result = Solution.RunningSum(numbers);
            
            result.Should().Equal(expected);            
        }      
    }
}
