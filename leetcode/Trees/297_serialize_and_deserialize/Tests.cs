using System.Collections.Generic;
using Xunit;

namespace leetcode.trees._serialize_and_deserialize
{
    public static class Tests
    {
        static Random rnd = new Random();

        private static TreeNode CreateDummy(int maxCount)
        {
            int currentCount = 0;

            TreeNode CreateNewNode()
            {
                if (currentCount == maxCount)
                {
                    return null;
                }

                currentCount++;
                return new TreeNode(rnd.Next(0, int.MaxValue));
            }

            List<TreeNode> nextNodes = new List<TreeNode>();
            var rootNode = CreateNewNode();
            nextNodes.Add(rootNode);

            while (currentCount <= maxCount)
            {
                var parentNodes = nextNodes;
                nextNodes = new List<TreeNode> { };

                foreach (var node in parentNodes)
                {
                    var newNode = CreateNewNode();
                    if (node == null)
                    {
                        return rootNode;
                    }

                    node.left = newNode;
                    nextNodes.Add(newNode);

                    newNode = CreateNewNode();
                    if (node == null)
                    {
                        return rootNode;
                    }

                    node.right = newNode;
                    nextNodes.Add(newNode);
                }
            }

            return rootNode;
        }


        [Fact]
        public static void Solution_Case_1()
        {
            TreeNode node = CreateDummy(1000000);

            var solution = new Solution1();

            var result1 = solution.serialize(node);
            var result2 = solution.deserialize(result1);
        }

        [Fact]
        public static void Solution_Case_2()
        {
            TreeNode node = CreateDummy(1000000);

            var solution = new Solution2();

            var result1 = solution.serialize(node);
            var result2 = solution.deserialize(result1);
        }
    }
}
  