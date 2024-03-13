namespace leetcode._binary_tree_level_order
{
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            var result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (true)
            {
                var curLevelCount = q.Count;
                if (curLevelCount == 0)
                {
                    break;
                }

                var curNodes = new List<int>();

                while (curLevelCount > 0)
                {
                    var cur = q.Dequeue();
                    curNodes.Add(cur.val);

                    if (cur.left != null)
                    {
                        q.Enqueue(cur.left);
                    }

                    if (cur.right != null)
                    {
                        q.Enqueue(cur.right);
                    }

                    curLevelCount--;
                }

                result.Add(curNodes);
            }

            return result;
        }
    }
}