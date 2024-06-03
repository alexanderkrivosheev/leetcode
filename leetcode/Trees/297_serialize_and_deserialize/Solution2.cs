using System.Net;

namespace leetcode.trees._serialize_and_deserialize
{
    public class Solution2
    {
        public string serialize(TreeNode root)
        {
            List<string> dfs(TreeNode node)
            {
                if (node == null)
                {
                    return new List<string>() { "null" };
                }

                var result = new List<string> { $"{node.val}" };

                result.AddRange(dfs(node.left));
                result.AddRange(dfs(node.right));

                return result;
            }

            return string.Join(",", dfs(root));
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            TreeNode dfs(Queue<string> nodeValues)
            {
                if (nodeValues.Count == 0)
                {
                    return null;
                }

                var nextValue = nodeValues.Dequeue();

                if (nextValue == "null")
                {
                    return null;
                }

                TreeNode result = null;

                if (int.TryParse(nextValue, out int value))
                {
                    result = new TreeNode(value);
                }

                if (result == null)
                {
                    return result;
                }

                result.left = dfs(nodeValues);
                result.right = dfs(nodeValues);

                return result;
            }


            if (string.IsNullOrEmpty(data))
            {
                return null;
            }


            TreeNode rootNode = new TreeNode();
            var nodeValues = new Queue<string>(data.Split(','));

            return dfs(nodeValues);

        }
    }
}