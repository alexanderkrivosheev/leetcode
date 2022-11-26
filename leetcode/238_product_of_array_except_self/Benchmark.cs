using BenchmarkDotNet.Attributes;
using leetcode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._238_product_of_array_except_self
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
            solution.ProductExceptSelf(_data);
        }

        [Benchmark]
        public void Solution2()
        {
            Solution2 solution = new Solution2();
            solution.ProductExceptSelf(_data);
        }
    }
}
