using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._longest_repeating
{
    public static class Tests
    {
        [Theory]

        [InlineData("ABAA", 0,2)]
        //[InlineData(new int[] { 1, 2, 3 },4)]
        public static void Solution_Case_1(string s, int k, int expeted)
        {
            Solution1 solution = new Solution1();
            var result = solution.CharacterReplacement(s,k);
            Assert.Equal(expeted, result);
        }

    }
}
  