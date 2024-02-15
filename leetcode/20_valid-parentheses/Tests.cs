using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._valid_parentheses
{
    public static class Tests
    {
        [Theory]

        [InlineData("()", true)]
        //[InlineData(new int[] { 1, 2, 3 },4)]
        public static void Solution_Case_1(string s, bool expeted)
        {
            Solution1 solution = new Solution1();
            var result = solution.IsValid(s);
            Assert.Equal(expeted, result);
        }

    }
}
  