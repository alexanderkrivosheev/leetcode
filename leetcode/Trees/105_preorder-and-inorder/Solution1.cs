namespace leetcode._preorder_and_inorder
{
    public class Solution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTreeImpl(preorder, inorder, 0, 0, preorder.Length);
        }

        public TreeNode BuildTreeImpl(int[] preorder, int[] inorder, int preIndex = 0, int inL = 0, int inR = 0)
        {
            if (preorder.Length == 0 || inorder.Length == 0)
            {
                return null;
            }

            if (preIndex > preorder.Length - 1 || inL > inR)
            {
                return null;
            }

            var newNode = new TreeNode(val: preorder[preIndex]);

            int mid = inL;
            while (inorder[mid] != newNode.val)
            {
                mid++;
            }

            newNode.left = BuildTreeImpl(preorder, inorder, preIndex + 1, inL, mid - 1);
            newNode.right = BuildTreeImpl(preorder, inorder, preIndex + mid - inL + 1, mid + 1, inR);

            return newNode;
        }
    }
}