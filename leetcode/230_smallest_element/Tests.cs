using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._smallest_element
{
    public static class Tests
    {
        [Theory]

        [InlineData(1)]
        public static void Solution_Case_1(int l)
        {
            TreeNode head = new TreeNode() { val = 1 };
            var node = head;

            head.left = new TreeNode() { val = 2 };
            head.right = new TreeNode() { val = 3 };
           
            var solution = new Solution1();
            solution.KthSmallest(head,1);
            
        }
    }
}
  