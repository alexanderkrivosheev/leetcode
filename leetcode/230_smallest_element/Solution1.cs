using Iced.Intel;
using leetcode._205_reverse_linked_list;
using System.Configuration;

namespace leetcode._smallest_element
{
    public class Solution1
    {
        public int KthSmallest(TreeNode root, int k)
        {
            return HandleNode(root, ref k).Value;
        }

        private int? HandleNode(TreeNode root, ref int k)
        {
            if (root.left != null)
            {
                var res = HandleNode(root.left, ref k);
                if (res.HasValue)
                {
                    return res;
                }
            }

            k--;
            if (k <= 0)
            {
                return root.val;
            }

            if (root.right != null)
            {
                var res = HandleNode(root.right, ref k);
                if (res.HasValue)
                {
                    return res;
                }
            }

            return null;
        }
    }
}