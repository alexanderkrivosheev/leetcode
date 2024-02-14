using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._minimum_window_substring
{
    public static class Tests
    {
        [Theory]

        [InlineData("aaaaaaaaaaaabbbbbcdd", "abcdd", "abbbbbcdd")]
        //[InlineData(new int[] { 1, 2, 3 },4)]
        public static void Solution_Case_1(string s, string t, string expeted)
        {
            Solution2 solution = new Solution2();
            var result = solution.MinWindow(s,t);
            Assert.Equal(expeted, result);
        }

    }
}
  