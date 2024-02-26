using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode._remove_nth_nod
{
    public class Solution2
    {
        public ListNode ReverseList(ListNode head)
        {
            return ReverseList(null, head);      
        }

        public ListNode ReverseList(ListNode prev, ListNode current)
        {
            ListNode nextNode = current.next;
            current.next = prev;

            if (nextNode != null)
            {
                return ReverseList(current, nextNode);
            }

            return current;
        }

    }
}