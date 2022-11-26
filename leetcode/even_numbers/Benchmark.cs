using BenchmarkDotNet.Attributes;
using leetcode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.even_numbers
{
    [MemoryDiagnoser]        
    public class Benchmark
    {

        private static int[] _data = null;

        static Benchmark()
        {
            _data = Utils.GenerateArray(10000000);
        }


        [Benchmark]
        public void Solution1()
        {
            Solution1 solution = new Solution1();
            solution.TotalAllEvenNumbers(_data);
        }
    }
}
