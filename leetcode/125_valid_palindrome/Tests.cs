using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._125_valid_palindrome
{
    public static class Tests
    {
        [Theory]
        [InlineData("0P")]        
        public static void Solution_Case_1(string value)
        {
            Solution1 solution = new Solution1();
            var result = solution.IsPalindrome(value);
        }

    }
}
  