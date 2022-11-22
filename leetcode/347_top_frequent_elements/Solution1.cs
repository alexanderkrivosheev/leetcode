using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._347_top_frequent_elements
{
    public class Solution1
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            List<List<int>> orderTable = new List<List<int>>();
            Dictionary<int, int> indexTable = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (indexTable.ContainsKey(nums[i]))
                {
                    var currentIndex = indexTable[nums[i]];
                    var newIndex = indexTable[nums[i]] + 1;

                    orderTable[currentIndex].Remove(nums[i]);

                    if (orderTable.Count <= newIndex)
                    {
                        orderTable.Add(new List<int>());
                    }

                    orderTable[newIndex].Add(nums[i]);
                    indexTable[nums[i]] = newIndex;
                }
                else
                {
                    indexTable.Add(nums[i], 0);

                    if (orderTable.Count <= 0)
                    {
                        orderTable.Add(new List<int>());
                    }

                    orderTable[0].Add(nums[i]);
                }
            }

            int[] result = new int[k];
            int index = 0;

            for (int i = orderTable.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < orderTable[i].Count; j++)
                {
                    result[index++] = orderTable[i][j];
                    if (index >= result.Length)
                    {
                        return result;
                    }
                }
            }

            return result;
        }
    }
}
