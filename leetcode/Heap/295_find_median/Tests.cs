using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace leetcode.Heap
{
    public static class Tests
    {
        [Fact]
        public static void Solution_Case_1()
        {

            MedianFinder finder = new MedianFinder();
            finder.AddNum(1);    // arr = [1]
            finder.AddNum(2);    // arr = [1, 2]
            var result = finder.FindMedian(); // return 1.5 (i.e., (1 + 2) / 2)
            finder.AddNum(3);    // arr[1, 2, 3]
            result = finder.FindMedian(); // return 2.0

        }
    }
}
  