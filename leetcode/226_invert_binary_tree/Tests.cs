﻿using Xunit;

namespace leetcode._invert_binary_tree
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

            var solution = new Solution();
            solution.InvertTree(head);
        }
    }
}
  