using Xunit;

namespace leetcode.trees._serialize_and_deserialize
{
    public static class Tests
    {
        [Fact]
        public static void Solution_Case_1()
        {
            TreeNode head = new TreeNode() { val = 1 };
            head.left = new TreeNode() { val = 2 };

            head.right = new TreeNode() { val = 3 };
            var node = head.right;

            node.left = new TreeNode() { val = 4 };
            node.right = new TreeNode() { val = 5 };


            var solution = new Solution1();

            var result1 = solution.serialize(head);
            var result2 = solution.deserialize(result1);
        }

        [Fact]
        public static void Solution_Case_2()
        {

            TreeNode head = new TreeNode() { val = 1 };
            head.left = new TreeNode() { val = 2 };

            head.right = new TreeNode() { val = 3 };
            var node = head.right;

            node.left = new TreeNode() { val = 4 };
            node.right = new TreeNode() { val = 5 };


            var solution = new Solution2();

            var result1 = solution.serialize(head);
            var result2 = solution.deserialize(result1);
        }
    }
}
  