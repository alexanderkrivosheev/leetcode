using BenchmarkDotNet.Attributes;
using FluentAssertions.Equivalency;
using leetcode.Helpers;


namespace leetcode.trees._serialize_and_deserialize
{
    [MemoryDiagnoser]        
    public class Benchmark
    {
        private static TreeNode _rootNode = null;
        static string _text;
        Random rnd = new Random();

        public Benchmark()
        {
            _rootNode = CreateDummyData(1000000);
        }

        private TreeNode CreateDummyData(int maxCount)
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

            Queue<TreeNode> queue = new Queue<TreeNode>();
            var rootNode = CreateNewNode();
            queue.Enqueue(_rootNode);

            while (currentCount <= maxCount)
            {
                foreach (var node in queue)
                {
                    var newNode = CreateNewNode();
                    if (node == null)
                    {
                        return rootNode;
                    }

                    node.left = newNode;
                    queue.Enqueue(newNode);

                    newNode = CreateNewNode();
                    if (node == null)
                    {
                        return rootNode;
                    }

                    node.right = newNode;
                    queue.Enqueue(newNode);
                }
            }

            return rootNode;
        }

        [Benchmark]
        public void BFS()
        {
            var solution = new Solution1();

            var result1 = solution.serialize(_rootNode);
            //var result2 = solution.deserialize(result1);
        }

        [Benchmark]
        public void DFS()
        {
            var solution = new Solution2();

            var result1 = solution.serialize(_rootNode);
            //var result2 = solution.deserialize(result1);
        }
    }
}
