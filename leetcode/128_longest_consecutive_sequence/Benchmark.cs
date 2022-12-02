using BenchmarkDotNet.Attributes;
using leetcode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._128_longest_consecutive_sequence
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
            solution.LongestConsecutive(_data);
        }

        [Benchmark]
        public void Solution2()
        {
            Solution2 solution = new Solution2();
            solution.LongestConsecutive(_data);
        }
    }
}
