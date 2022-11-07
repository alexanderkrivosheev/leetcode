using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._217_contains_duplicate
{
    [MemoryDiagnoser]        
    public class Benchmark
    {
        [Benchmark]
        public void Solution1()
        {
            Solution1 solution = new Solution1();
            solution.ContainsDuplicate(new int[] { 1, 2, 3, 4, 1 });
        }

        [Benchmark]
        public void Solution2()
        {
            Solution2 solution = new Solution2();
            solution.ContainsDuplicate(new int[] { 1, 2, 3, 4, 1 });
        }

        [Benchmark]
        public void Solution3()
        {
            Solution2 solution = new Solution2();
            solution.ContainsDuplicate(new int[] { 1, 2, 3, 4, 1 });
        }
    }
}
