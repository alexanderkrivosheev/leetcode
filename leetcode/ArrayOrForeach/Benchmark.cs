using BenchmarkDotNet.Attributes;
using leetcode.Helpers;

namespace leetcode.ArrayOrForeach
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        private static int[] _data2;

        static Benchmark()
        {
            _data2 = Utils.GenerateArray(1000000);
        }


        [Benchmark]
        public void For_Loop()
        {

            bool lastIsEven = false;
            for (int i = 0; i < _data2.Length; i++)
            {
                if (_data2[i] % 2 == 0)
                {
                    lastIsEven = true;
                }
                else
                {
                    lastIsEven = false;
                }
            }
        }

        [Benchmark]
        public void Foreach_Loop()
        {
            bool lastIsEven = false;
            foreach (var item in _data2)
            {
                if (item % 2 == 0)
                {
                    lastIsEven = true;
                }
                else
                {
                    lastIsEven = false;
                }
            }

        }
    }
}
