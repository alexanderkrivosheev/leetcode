﻿using BenchmarkDotNet.Attributes;
using leetcode.Helpers;


namespace leetcode._smallest_element
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
