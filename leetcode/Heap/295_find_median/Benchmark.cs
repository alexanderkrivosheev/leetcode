using BenchmarkDotNet.Attributes;
using leetcode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Heap
{
    [MemoryDiagnoser]        
    public class Benchmark
    {

        private static ICollection<int> _data1;
        private static int[] _data2;
        private static List<int> _data3;
        
        static Benchmark()
        {
            _data1 = Utils.GenerateCollection(1000000);
            _data2 = Utils.GenerateArray(1000000);
            _data3 = Utils.GenerateList(1000000);
        }


        [Benchmark]
        public void Enumerable_ToArray()
        {
            var test = Utils.GenerateEnumerable(1000000).ToArray();
        }

        [Benchmark]
        public void Enumerable_ToList()
        {
            var test = Utils.GenerateEnumerable(1000000).ToList();
        }

        [Benchmark]
        public void Collection_ToList()
        {
            var test = _data1.ToList();
        }

        [Benchmark]
        public void Collection_ToArray()
        {
            var test = _data1.ToArray();
        }

        [Benchmark]
        public void Array_ToList()
        {
            var test = _data2.ToList();
        }

        [Benchmark]
        public void List_ToArray()
        {
            var test = _data3.ToList();
        }

        [Benchmark]
        public void Linq_ToArray()
        {
            var test = _data1.Where(d => d > 0).ToArray();
        }

        [Benchmark]
        public void Linq_ToList()
        {
            var test = _data1.Where(d => d > 0).ToList();
        }
    }
}
