using BenchmarkDotNet.Attributes;
using leetcode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._search_rotated_array
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
        public static void Solution1()
        {
           
        }

        [Benchmark]
        public static void Solution2()
        {
       
        }
    }
}
