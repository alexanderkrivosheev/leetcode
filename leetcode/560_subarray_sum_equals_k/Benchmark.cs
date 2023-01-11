using BenchmarkDotNet.Attributes;
using leetcode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._560_subarray_sum_equals_k
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
            var result = solution.SubarraySum(_data,3);
        }

        [Benchmark]
        public void Solution2()
        {
            Solution1 solution = new Solution1();
            var result = solution.SubarraySum(_data,3);
        }
    }
}
