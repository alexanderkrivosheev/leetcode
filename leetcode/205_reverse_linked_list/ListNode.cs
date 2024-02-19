using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._205_reverse_linked_list
{
    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.Val = val;
            this.Next = next;
        }
    }
}
