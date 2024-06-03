using BenchmarkDotNet.Attributes;
using leetcode.Helpers;


namespace leetcode.trees._serialize_and_deserialize
{
    [MemoryDiagnoser]        
    public class Benchmark
    {
        private static TreeNode _rootNode = null;

        public Benchmark()
        {
            _rootNode = new TreeNode() { val = 1 };
            _rootNode.left = new TreeNode() { val = 2 };

            _rootNode.right = new TreeNode() { val = 3 };
            var node = _rootNode.right;

            node.left = new TreeNode() { val = 4 };
            node.right = new TreeNode() { val = 5 };

        }

        [Benchmark]
        public void Solution1()
        {
            var solution = new Solution1();

            var result1 = solution.serialize(_rootNode);
            var result2 = solution.deserialize(result1);
        }

        [Benchmark]
        public void Solution2()
        {
            var solution = new Solution2();

            var result1 = solution.serialize(_rootNode);
            var result2 = solution.deserialize(result1);
        }
    }
}
