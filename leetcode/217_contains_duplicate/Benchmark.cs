using BenchmarkDotNet.Attributes;
using leetcode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._217_contains_duplicate
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
            solution.ContainsDuplicate(_data);
        }

        [Benchmark]
        public void Solution2()
        {
            Solution2 solution = new Solution2();
            solution.ContainsDuplicate(_data);
        }

        [Benchmark]
        public void Solution3()
        {
            Solution3 solution = new Solution3();
            solution.ContainsDuplicate(_data);
        }

        [Benchmark]
        public void Solution4()
        {
            Solution4 solution = new Solution4();
            solution.ContainsDuplicate(_data);
        }
    }
}
