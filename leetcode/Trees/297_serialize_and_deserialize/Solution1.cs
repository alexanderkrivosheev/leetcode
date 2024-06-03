namespace leetcode.trees._serialize_and_deserialize
{
    public class Solution1
    {
        public string serialize(TreeNode root)
        {            
            List<string> result = new List<string>();
            Queue<TreeNode> nextNodes = new Queue<TreeNode>();
            nextNodes.Enqueue(root);
         
 
            while (nextNodes.Count() > 0)
            {
                Queue<TreeNode> childNodes = nextNodes;
                nextNodes = new Queue<TreeNode>();

                foreach (var node in childNodes)
                {
                    result.Add($"{(node?.val.ToString() ?? "null")}");

                    if (node != null)
                    {
                        nextNodes.Enqueue(node.left);
                        nextNodes.Enqueue(node.right);
                    }
                }
            }

            return string.Join(",", result);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            TreeNode rootNode = new TreeNode();

            if (string.IsNullOrEmpty(data))
            {
                return null;
            }

            Queue<string> nodeValues = new Queue<string>(data.Split(','));
            Queue<TreeNode> nextNodes = new Queue<TreeNode>();

            if(nodeValues.Count() == 0)
            {
                return rootNode;
            }

            var rootNodeValue = nodeValues.Dequeue();
            if (rootNodeValue != null && int.TryParse(rootNodeValue, out int value))
            {
                rootNode = new TreeNode(value);
                nextNodes.Enqueue(rootNode);
            }

            while (nextNodes.Count() > 0)
            {
                Queue<TreeNode> parentNodes = nextNodes;
                nextNodes = new Queue<TreeNode>();

                foreach (var parent in parentNodes)
                {
                    if (nodeValues.Count() == 0)
                    {
                        break;
                    }

                    var leftNodeValue = nodeValues.Dequeue();

                    if (leftNodeValue != null && int.TryParse(leftNodeValue, out int leftValue))
                    {
                        parent.left = new TreeNode(leftValue);
                        nextNodes.Enqueue(parent.left);
                    }

                    if (nodeValues.Count() == 0)
                    {
                        break;
                    }

                    var rightNodeValue = nodeValues.Dequeue();

                    if (rightNodeValue != null && int.TryParse(rightNodeValue, out int rightValue))
                    {
                        parent.right = new TreeNode(rightValue);
                        nextNodes.Enqueue(parent.right);
                    }
                }
            }

            return rootNode;

        }
    }
}