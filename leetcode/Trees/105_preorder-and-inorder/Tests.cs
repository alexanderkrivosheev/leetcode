using Xunit;

namespace leetcode._preorder_and_inorder
{
    public static class Tests
    {
        [Theory]

        [InlineData(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 })]
        public static void Solution_Case_1(int[] preorder, int[] inorder)
        {
            var solution = new Solution();
            solution.BuildTree(preorder, inorder);
        }
    }
}
  