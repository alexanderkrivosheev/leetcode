using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._242_valid_anagram
{ 
    public static class Tests
    {
        [Theory]
        [InlineData("ab", "ba",true)]
        [InlineData("aba", "baa", true)]
        [InlineData("aba", "bac", false)]
        public static void Solution_Case_1(string s, string t, bool expected)
        {
            Solution1 solution = new Solution1();
            var result = solution.IsAnagram(s, t);
            
            Assert.Equal(expected, result);
        }      
    }
}
  