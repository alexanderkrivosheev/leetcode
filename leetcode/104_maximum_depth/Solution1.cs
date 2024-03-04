namespace leetcode._maximum_depth
{
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right == null)
            {
                return 1;
            }

            if (root.left == null && root.right != null)
            {
                return MaxDepth(root.right) + 1;
            }

            if (root.right == null && root.left != null)
            {
                return MaxDepth(root.left) + 1;
            }

            var lefDepth = MaxDepth(root.left);
            var rightDepth = MaxDepth(root.right);

            return (lefDepth > rightDepth ? lefDepth : rightDepth) + 1;
        }
    }
}