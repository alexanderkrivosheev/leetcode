using Xunit;

namespace leetcode._same_tree
{
    public static class Tests
    {
        [Theory]


        [InlineData(1)]
        public static void Solution_Case_1(int l)
        {
            TreeNode head = new TreeNode() { val = 1 };
            head.left = new TreeNode() { val = 2 };
            head.right = new TreeNode() { val = 3 };

            TreeNode head2 = new TreeNode() { val = 1 };
            head2.left = new TreeNode() { val = 2 };
            head2.right = new TreeNode() { val = 3 };

            var solution = new Solution();
            solution.IsSameTree(head, head2);
        }
    }
}
  