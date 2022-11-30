using BenchmarkDotNet.Attributes;
using leetcode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode._36_valid_sudoku
{
    [MemoryDiagnoser]        
    public class Benchmark
    {
        private static char[][] _data = null;

        static Benchmark()
        {
            _data =  new char[9][];
            _data[0] = new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
            _data[1] = new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            _data[2] = new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };

            _data[3] = new char[] { '8', '.', '.', '.', '6', '.', '4', '.', '3' };
            _data[4] = new char[] { '4', '.', '.', '8', '.', '3', '3', '.', '1' };
            _data[5] = new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };

            _data[6] = new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            _data[7] = new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            _data[8] = new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };
        }

        [Benchmark]
        public void Solution1()
        {
            Solution1 solution = new Solution1();
            var result = solution.IsValidSudoku(_data);
        }

        [Benchmark]
        public void Solution2()
        {
            Solution2 solution = new Solution2();
            var result = solution.IsValidSudoku(_data);            
        }
    }
}
