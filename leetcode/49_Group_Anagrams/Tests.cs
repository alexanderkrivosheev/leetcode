using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._49_Group_Anagrams
{
    public static class Tests
    {

        [Fact]
       
        public static void Solution_Case_1()
        {
            Solution1 solution = new Solution1();
            var result = solution.GroupAnagrams(new string[] { "", "b" });
            string[][] expected = new string[3][];
            expected[0] = new string[] { "bat" };
            expected[1] = new string[] { "nat", "tan" };
            expected[2] = new string[] { "ate", "eat", "tea" };
            
            result.Should().Equal(expected);
        }

        [Fact]
        public static void Solution_Case_2()
        {
            Solution2 solution = new Solution2();
            var result = solution.GroupAnagrams(new string[] { "", "b" });
            string[][] expected = new string[3][];
            expected[0] = new string[] { "bat" };
            expected[1] = new string[] { "nat", "tan" };
            expected[2] = new string[] { "ate", "eat", "tea" };

            result.Should().Equal(expected);
        }
    }
}
  