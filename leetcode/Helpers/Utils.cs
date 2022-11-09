using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Helpers
{
    public static class Utils
    {
        public static int[] GenerateArray(int max)
        {
            int[] result = new int[max];
            Random random = new Random();
            for (int i = 0; i < max; i++)
            {
                result[i] = random.Next();
            }

            return result;
        }

        public static List<int> GenerateList(int max)
        {
            List<int> result = new List<int>();
            Random random = new Random();
            for (int i = 0; i < max; i++)
            {
                result.Add(random.Next());
            }

            return result;
        }

        public static ICollection<int> GenerateCollection(int max)
        {
            ICollection<int> result = new Collection<int>();
            Random random = new Random();
            for (int i = 0; i < max; i++)
            {
                result.Add(random.Next());
            }

            return result;
        }

        public static IEnumerable<int> GenerateEnumerable(int max)
        {
            Random random = new Random();
            for (int i = 0; i < max; i++)
            {
                yield return random.Next();
            }
        }
    }
}
