using BenchmarkDotNet.Attributes;
using leetcode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.StructOrReference
{
    [MemoryDiagnoser]        
    public class Benchmark
    {

        public struct PointStr
        {
            public int Count;
            public byte IsHidden;
            public string Title;
            public float Locaton;
        }

        public class PointRef
        {
            public int Count;
            public byte IsHidden;
            public string Title;
            public float Locaton;
        }

        private const int Length = 1000000;

        
        static Benchmark()
        {
           
        }


        [Benchmark]
        public void Structs()
        {
            PointStr[] result = new PointStr[Length];
            for (int i = 0; i < Length; i++)
            {
                result[0] = new PointStr();
            }
        }

        [Benchmark]
        public void References()
        {
            PointRef[] result = new PointRef[Length];
            for (int i = 0; i < Length; i++)
            {
                result[i] = new PointRef();
            }
        }

    }
}
