using BenchmarkDotNet.Attributes;
using leetcode.Helpers;

namespace leetcode._347_top_frequent_elements
{
    [MemoryDiagnoser]        
    public class Benchmark
    {

        private static int[] _data = null;

        static Benchmark()
        {
            _data = Utils.GenerateArray(1000000);
        }


        [Benchmark]
        public void Solution1()
        {
            Solution1 solution = new Solution1();
            solution.TopKFrequent(_data, 4);
        }
        [Benchmark]
        public void Solution2()
        {
            Solution2 solution = new Solution2();
            solution.TopKFrequent(_data, 4);
        }
        [Benchmark]
        public void Solution3()
        {
            Solution3 solution = new Solution3();
            solution.TopKFrequent(_data, 4);
        }

        [Benchmark]
        public void Solution4()
        {
            Solution4 solution = new Solution4();
            solution.TopKFrequent(_data, 4);
        }
    }
}
