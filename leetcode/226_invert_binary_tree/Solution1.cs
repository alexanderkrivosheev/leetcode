namespace leetcode._invert_binary_tree
{
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {

            return InvertNode(root);
        }

        public TreeNode InvertNode(TreeNode root)
        {

            if (root == null)
            {
                return null;
            }

            var left = root.left;
            var right = root.right;

            if (right != null)
            {
                root.left = InvertNode(right);
            }
            else
            {
                root.left = null;
            }

            if (left != null)
            {
                root.right = InvertNode(left);
            }
            else
            {
                root.right = null;
            }

            return root;
        }
    }
}