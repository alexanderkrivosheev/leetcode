using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Heap
{
    public class MedianFinder        
    {
        private PriorityQueue<int, int> SmallHeap = new PriorityQueue<int, int>();
        private PriorityQueue<int, int> LargeHeap = new PriorityQueue<int, int>();

        public MedianFinder()
        {
            
        }

        
        public void AddNum(int num)
        {
            int? maxSmallHeap = SmallHeap.Count>0? SmallHeap.Peek(): null;
            int? maxLargeHeap = LargeHeap.Count>0? LargeHeap.Peek():null;


            if(maxLargeHeap.HasValue && num > maxLargeHeap.Value)
            {
                LargeHeap.Enqueue(num, num);
            }
            else
            {
                SmallHeap.Enqueue(num, -num);
            }

            if (SmallHeap.Count > LargeHeap.Count + 1)
            {
                maxSmallHeap = SmallHeap.Dequeue();
                LargeHeap.Enqueue(maxSmallHeap.Value, maxSmallHeap.Value);
            }

            if (LargeHeap.Count > SmallHeap.Count + 1)
            {
                maxSmallHeap = LargeHeap.Dequeue();
                SmallHeap.Enqueue(maxSmallHeap.Value, -maxSmallHeap.Value);
            }
        }

        public double FindMedian()
        {
            if(SmallHeap.Count == LargeHeap.Count)
            {
                return (a + b) /2.0;
            }

            if (SmallHeap.Count > LargeHeap.Count)
            {
                return SmallHeap.Peek();
            }

            if (SmallHeap.Count < LargeHeap.Count)
            {
                return LargeHeap.Peek();
            }

            return 0;
        }
    }
}
