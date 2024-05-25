using Xunit;

namespace leetcode.trees.binary_tree_maximum_path_sum
{
    public static class Tests
    {
        [Fact]        
        public static void Solution_Case_1()
        {
            TreeNode head = new TreeNode() { val = -10 };
            var node = head;

            head.left = new TreeNode() { val = 9 };



            head.right = new TreeNode() { val = 20 };
            head.right.left = new TreeNode { val = 15 };
            head.right.right = new TreeNode { val = 7 };

            var solution = new Solution();
            var result = solution.MaxPathSum(head);
        }
    }
}
  