using BenchmarkDotNet.Attributes;
using leetcode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace leetcode._49_Group_Anagrams
{
    [MemoryDiagnoser]        
    public class Benchmark
    {
        
        private static string[] _data1;
        

        static Benchmark()
        {
            _data1 = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };


        }


        [Benchmark]
        public void Solution1()
        {
            Solution1 solution = new Solution1();
            var result = solution.GroupAnagrams(_data1);
        }

        [Benchmark]
        public void Solution2()
        {
            Solution1 solution = new Solution1();
            var result = solution.GroupAnagrams(_data1);
        }


        [Benchmark]
        public void Solution3()
        {
            Solution3 solution = new Solution3();
            var result = solution.GroupAnagrams(_data1);
        }

        [Benchmark]
        public void Solution4()
        {
            Solution4 solution = new Solution4();
            var result = solution.GroupAnagrams(_data1);
        }
    }
}
