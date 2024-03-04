namespace leetcode._same_tree
{
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if ((p == null && q != null) || (q == null && p != null))
            {
                return false;
            }

            if (p != null && q != null)
            {
                if (p.val != q.val)
                {
                    return false;
                }

                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }

            return true;
        }
    }
}