using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._242_valid_anagram
{
    [MemoryDiagnoser]        
    public class Benchmark
    {
        [Benchmark]
        public void Solution1()
        {
            Solution1 solution = new Solution1();
            solution.IsAnagram("aaabbbbccc", "cbabcababc");
        }

        [Benchmark]
        public void Solution2()
        {
            Solution2 solution = new Solution2();
            solution.IsAnagram("aaabbbbccc", "cbabcababc");
        }

        [Benchmark]
        public void Solution3()
        {
            Solution1 solution = new Solution1();
            solution.IsAnagram("aaabbbbcccaaabbbbcccaaabbbbcccaaabbbbcccaaabbbbcccaaabbbbccc", "cbabcababccbabcababccbabcababccbabcababccbabcababccbabcababc");
        }
    }
}
