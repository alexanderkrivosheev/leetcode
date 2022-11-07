using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._1480_running_sum_id_array
{
    [MemoryDiagnoser]        
    public class Benchmark
    {
        [Benchmark]
        public void Solution1()
        {
            Solution1 solution = new Solution1();
            solution.RunningSum(new int[] { 1, 2, 3, 4 });
        }
    }
}
