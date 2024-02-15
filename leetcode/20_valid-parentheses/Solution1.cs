using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._valid_parentheses
{    
    public class Solution1
    {
        public bool IsValid(string s)
        {

            var pairs = new Dictionary<char, char>()
        {
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };

            var set = new Stack<char>();

            foreach (var item in s)
            {
                if (pairs.ContainsKey(item))
                {
                    set.Push(pairs[item]);
                }
                else
                {
                    if (set.Count == 0)
                    {
                        return false;
                    }

                    var closedItem = set.Pop();

                    if (item != closedItem)
                    {
                        return false;
                    }
                }
            }

            return set.Count == 0 ? true : false;
        }
    }
}
