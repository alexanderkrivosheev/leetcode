using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._longest_substring
{
    public static class Tests
    {
        [Theory]

        [InlineData("abcabcbb", 1)]
        //[InlineData(new int[] { 1, 2, 3 },4)]
        public static void Solution_Case_1(string s,int expeted)
        {
            Solution2 solution = new Solution2();
            var result = solution.LengthOfLongestSubstring(s);
            Assert.Equal(expeted, result);
        }

    }
}
  