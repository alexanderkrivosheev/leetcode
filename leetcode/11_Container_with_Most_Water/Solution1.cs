using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._11_Container_with_Most_Water
{
    public class Solution1
    {
        public int MaxArea(int[] height)
        {
            int literOfWater = 0;
            int start = 0;
            int end = height.Length - 1;
            int maxLiterOfWater = 0;

            do
            {
                literOfWater = Math.Min(height[start], height[end]) * (end - start);
                if (maxLiterOfWater < literOfWater)
                {
                    maxLiterOfWater = literOfWater;
                }

                if (height[start] < height[end])
                {
                    start++;
                }
                else
                {
                    end--;
                }

            } while (start < end);

            return maxLiterOfWater;
        }
    }
}
